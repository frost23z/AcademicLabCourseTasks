using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set default tax rate
            TXT_Tax_Rate.Text = "15";
        }

        private decimal CalculateTax(decimal price, decimal taxRate)
        {
            return price * (taxRate / 100);
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TXT_Item_Price.Text) || string.IsNullOrEmpty(TXT_Tax_Rate.Text))
                {
                    MessageBox.Show("Please enter both price and tax rate!");
                    return;
                }

                decimal price = decimal.Parse(TXT_Item_Price.Text);
                decimal taxRate = decimal.Parse(TXT_Tax_Rate.Text);

                DGV_Items.Rows.Add(
                    price.ToString("C"),
                    taxRate.ToString("0.00") + "%"
                );

                TXT_Item_Price.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers!");
            }
        }

        private void BTN_Calculate_Total_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0;
            decimal totalTax = 0;

            foreach (DataGridViewRow row in DGV_Items.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string priceStr = row.Cells[0].Value.ToString().Replace("$", "");
                    string taxRateStr = row.Cells[1].Value.ToString().Replace("%", "");
                    
                    decimal price = decimal.Parse(priceStr);
                    decimal taxRate = decimal.Parse(taxRateStr);
                    
                    subtotal += price;
                    totalTax += price * (taxRate / 100);
                }
            }

            decimal finalTotal = subtotal + totalTax;

            LB_Subtotal_Value.Text = subtotal.ToString("C");
            LB_Tax_Amount_Value.Text = totalTax.ToString("C");
            LB_Final_Total_Value.Text = finalTotal.ToString("C");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
