using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string directory = textBox1.Text;

            if (Directory.Exists(directory))
            {
                LoadFilesIntoGrid(directory);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string itemType = dataGridView1.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                string fullPath = dataGridView1.Rows[e.RowIndex].Cells["FullPath"].Value.ToString();

                if (itemType == "Folder")
                {
                    // Update the textbox with the new path and load the contents
                    textBox1.Text = fullPath;
                    LoadFilesIntoGrid(fullPath);
                }
                else
                {
                    // Handle file opening
                    try
                    {
                        Process.Start(fullPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening file: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = folderDialog.SelectedPath;
                    LoadFilesIntoGrid(folderDialog.SelectedPath);
                }
            }
        }

        private void LoadFilesIntoGrid(string directory)
        {
            try
            {
                // Get directories
                var directories = Directory.GetDirectories(directory)
                                         .Select(d => new DirectoryInfo(d))
                                         .Select(d => new
                                         {
                                             Name = d.Name,
                                             FullPath = d.FullName,
                                             Type = "Folder",
                                             Size = "-",
                                             LastModified = d.LastWriteTime
                                         });

                // Get files
                var files = Directory.GetFiles(directory)
                                     .Select(f => new FileInfo(f))
                                     .Select(f => new
                                     {
                                         Name = f.Name,
                                         FullPath = f.FullName,
                                         Type = "File",
                                         Size = f.Length.ToString(),
                                         LastModified = f.LastWriteTime
                                     });

                // Combine folders and files
                var items = directories.Concat(files).ToList();

                // Clear previous data
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Add columns to DataGridView
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Type", "Type");
                dataGridView1.Columns.Add("Size", "Size");
                dataGridView1.Columns.Add("LastModified", "Last Modified");
                dataGridView1.Columns.Add("FullPath", "Full Path");
                dataGridView1.Columns["FullPath"].Visible = false;

                // Set column widths
                dataGridView1.Columns["Name"].Width = 200;
                dataGridView1.Columns["Type"].Width = 80;
                dataGridView1.Columns["Size"].Width = 100;
                dataGridView1.Columns["LastModified"].Width = 150;

                // Add rows for each item
                foreach (var item in items)
                {
                    dataGridView1.Rows.Add(item.Name, item.Type, item.Size, item.LastModified, item.FullPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading files: " + ex.Message);
            }
        }
    }
}
