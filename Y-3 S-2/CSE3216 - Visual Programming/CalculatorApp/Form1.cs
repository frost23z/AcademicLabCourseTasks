using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String resultValue, option;
        int num1, num2, result;

        public String connString = "Data Source=LAPTOP-UP56O9MB\\SQLEXPRESS;Initial Catalog=MBSTU-CSE;Integrated Security=True;TrustServerCertificate=True";


        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text = txtBoxValue.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text = txtBoxValue.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text = txtBoxValue.Text + button3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtBoxValue.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            String query = "insert into Calculator values ('"+result+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfullys");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBoxValue.Text = txtBoxValue.Text + btn4.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtBoxValue.Text);
            txtBoxValue.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtBoxValue.Text);
            if (option.Equals("+"))
            {
                result = num1 + num2;
            }
            txtBoxValue.Text = result + "";
   
        }
    }
}
