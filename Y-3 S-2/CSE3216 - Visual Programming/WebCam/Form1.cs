using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebCam
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private bool isCameraRunning = false;
        private Bitmap currentFrame = null;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                    throw new ApplicationException("No video devices found");

                foreach (FilterInfo device in videoDevices)
                {
                    comboBox1.Items.Add(device.Name);
                }
                comboBox1.SelectedIndex = 0;
                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing camera: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                button2.Enabled = false;
            }
        }

        private void StartCamera()
        {
            try
            {
                if (isCameraRunning)
                {
                    StopCamera();
                }

                if (comboBox1.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a camera");
                    return;
                }

                videoSource = new VideoCaptureDevice(videoDevices[comboBox1.SelectedIndex].MonikerString);
                videoSource.VideoResolution = videoSource.VideoCapabilities[0];
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
                isCameraRunning = true;

                button1.Text = "Stop";
                button2.Enabled = true;
                comboBox1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting camera: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopCamera()
        {
            try
            {
                if (videoSource != null)
                {
                    if (videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource.WaitForStop();
                    }
                    videoSource.NewFrame -= VideoSource_NewFrame;
                    videoSource = null;
                }

                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                button1.Text = "Start";
                button2.Enabled = false;
                comboBox1.Enabled = true;
                isCameraRunning = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error stopping camera: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action<object, NewFrameEventArgs>(VideoSource_NewFrame), sender, eventArgs);
                    return;
                }

                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }

                using (Bitmap originalFrame = (Bitmap)eventArgs.Frame.Clone())
                {
                    originalFrame.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pictureBox1.Image = (Bitmap)originalFrame.Clone();
                    currentFrame = (Bitmap)originalFrame.Clone();
                }
            }
            catch (Exception)
            {
                if (!this.IsDisposed && pictureBox1 != null)
                {
                    this.Invoke(new Action(() => StopCamera()));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isCameraRunning)
            {
                StartCamera();
            }
            else
            {
                StopCamera();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentFrame != null)
            {
                try
                {
                    using (Bitmap captureFrame = new Bitmap(currentFrame))
                    {
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "JPEG Image|*.jpg";
                            saveFileDialog.Title = "Save Captured Photo";
                            saveFileDialog.FileName = $"CapturedImage_{DateTime.Now:yyyyMMdd_HHmmss}.jpg";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                captureFrame.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                                MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private System.Drawing.Imaging.ImageCodecInfo GetEncoder(System.Drawing.Imaging.ImageFormat format)
        {
            System.Drawing.Imaging.ImageCodecInfo[] codecs = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders();
            foreach (System.Drawing.Imaging.ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopCamera();
            if (currentFrame != null)
            {
                currentFrame.Dispose();
                currentFrame = null;
            }
            base.OnFormClosing(e);
        }
    }
}
