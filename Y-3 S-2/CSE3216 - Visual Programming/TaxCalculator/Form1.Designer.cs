namespace TaxCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Item_Price = new System.Windows.Forms.Label();
            this.TXT_Item_Price = new System.Windows.Forms.TextBox();
            this.LB_Tax_Rate = new System.Windows.Forms.Label();
            this.TXT_Tax_Rate = new System.Windows.Forms.TextBox();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.DGV_Items = new System.Windows.Forms.DataGridView();
            this.Column_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Tax_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Calculate_Total = new System.Windows.Forms.Button();
            this.LB_Subtotal = new System.Windows.Forms.Label();
            this.LB_Subtotal_Value = new System.Windows.Forms.Label();
            this.LB_Tax_Amount = new System.Windows.Forms.Label();
            this.LB_Tax_Amount_Value = new System.Windows.Forms.Label();
            this.LB_Final_Total = new System.Windows.Forms.Label();
            this.LB_Final_Total_Value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Item_Price
            // 
            this.LB_Item_Price.AutoSize = true;
            this.LB_Item_Price.Location = new System.Drawing.Point(12, 24);
            this.LB_Item_Price.Name = "LB_Item_Price";
            this.LB_Item_Price.Size = new System.Drawing.Size(66, 16);
            this.LB_Item_Price.TabIndex = 0;
            this.LB_Item_Price.Text = "Item Price";
            // 
            // TXT_Item_Price
            // 
            this.TXT_Item_Price.Location = new System.Drawing.Point(142, 18);
            this.TXT_Item_Price.Name = "TXT_Item_Price";
            this.TXT_Item_Price.Size = new System.Drawing.Size(120, 22);
            this.TXT_Item_Price.TabIndex = 1;
            // 
            // LB_Tax_Rate
            // 
            this.LB_Tax_Rate.AutoSize = true;
            this.LB_Tax_Rate.Location = new System.Drawing.Point(12, 55);
            this.LB_Tax_Rate.Name = "LB_Tax_Rate";
            this.LB_Tax_Rate.Size = new System.Drawing.Size(62, 16);
            this.LB_Tax_Rate.TabIndex = 2;
            this.LB_Tax_Rate.Text = "Tax Rate";
            // 
            // TXT_Tax_Rate
            // 
            this.TXT_Tax_Rate.Location = new System.Drawing.Point(142, 55);
            this.TXT_Tax_Rate.Name = "TXT_Tax_Rate";
            this.TXT_Tax_Rate.Size = new System.Drawing.Size(120, 22);
            this.TXT_Tax_Rate.TabIndex = 3;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(78, 116);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(120, 28);
            this.BTN_Add.TabIndex = 4;
            this.BTN_Add.Text = "Add Item";
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // DGV_Items
            // 
            this.DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Price,
            this.Column_Tax_Rate});
            this.DGV_Items.Location = new System.Drawing.Point(329, 55);
            this.DGV_Items.Name = "DGV_Items";
            this.DGV_Items.RowHeadersWidth = 51;
            this.DGV_Items.Size = new System.Drawing.Size(343, 333);
            this.DGV_Items.TabIndex = 5;
            // 
            // Column_Price
            // 
            this.Column_Price.HeaderText = "Price";
            this.Column_Price.MinimumWidth = 6;
            this.Column_Price.Name = "Column_Price";
            this.Column_Price.Width = 150;
            // 
            // Column_Tax_Rate
            // 
            this.Column_Tax_Rate.HeaderText = "Tax Rate";
            this.Column_Tax_Rate.MinimumWidth = 6;
            this.Column_Tax_Rate.Name = "Column_Tax_Rate";
            this.Column_Tax_Rate.Width = 150;
            // 
            // BTN_Calculate_Total
            // 
            this.BTN_Calculate_Total.Location = new System.Drawing.Point(78, 187);
            this.BTN_Calculate_Total.Name = "BTN_Calculate_Total";
            this.BTN_Calculate_Total.Size = new System.Drawing.Size(120, 28);
            this.BTN_Calculate_Total.TabIndex = 6;
            this.BTN_Calculate_Total.Text = "Calculate Total";
            this.BTN_Calculate_Total.Click += new System.EventHandler(this.BTN_Calculate_Total_Click);
            // 
            // LB_Subtotal
            // 
            this.LB_Subtotal.AutoSize = true;
            this.LB_Subtotal.Location = new System.Drawing.Point(19, 320);
            this.LB_Subtotal.Name = "LB_Subtotal";
            this.LB_Subtotal.Size = new System.Drawing.Size(59, 16);
            this.LB_Subtotal.TabIndex = 7;
            this.LB_Subtotal.Text = "Subtotal:";
            // 
            // LB_Subtotal_Value
            // 
            this.LB_Subtotal_Value.AutoSize = true;
            this.LB_Subtotal_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.LB_Subtotal_Value.Location = new System.Drawing.Point(168, 318);
            this.LB_Subtotal_Value.Name = "LB_Subtotal_Value";
            this.LB_Subtotal_Value.Size = new System.Drawing.Size(100, 18);
            this.LB_Subtotal_Value.TabIndex = 14;
            this.LB_Subtotal_Value.Text = "$0.00";
            this.LB_Subtotal_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Tax_Amount
            // 
            this.LB_Tax_Amount.AutoSize = true;
            this.LB_Tax_Amount.Location = new System.Drawing.Point(19, 345);
            this.LB_Tax_Amount.Name = "LB_Tax_Amount";
            this.LB_Tax_Amount.Size = new System.Drawing.Size(33, 16);
            this.LB_Tax_Amount.TabIndex = 9;
            this.LB_Tax_Amount.Text = "Tax:";
            // 
            // LB_Tax_Amount_Value
            // 
            this.LB_Tax_Amount_Value.AutoSize = true;
            this.LB_Tax_Amount_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.LB_Tax_Amount_Value.Location = new System.Drawing.Point(168, 345);
            this.LB_Tax_Amount_Value.Name = "LB_Tax_Amount_Value";
            this.LB_Tax_Amount_Value.Size = new System.Drawing.Size(100, 18);
            this.LB_Tax_Amount_Value.TabIndex = 15;
            this.LB_Tax_Amount_Value.Text = "$0.00";
            this.LB_Tax_Amount_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Final_Total
            // 
            this.LB_Final_Total.AutoSize = true;
            this.LB_Final_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.LB_Final_Total.Location = new System.Drawing.Point(19, 370);
            this.LB_Final_Total.Name = "LB_Final_Total";
            this.LB_Final_Total.Size = new System.Drawing.Size(51, 18);
            this.LB_Final_Total.TabIndex = 11;
            this.LB_Final_Total.Text = "Total:";
            // 
            // LB_Final_Total_Value
            // 
            this.LB_Final_Total_Value.AutoSize = true;
            this.LB_Final_Total_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.LB_Final_Total_Value.Location = new System.Drawing.Point(168, 370);
            this.LB_Final_Total_Value.Name = "LB_Final_Total_Value";
            this.LB_Final_Total_Value.Size = new System.Drawing.Size(100, 18);
            this.LB_Final_Total_Value.TabIndex = 16;
            this.LB_Final_Total_Value.Text = "$0.00";
            this.LB_Final_Total_Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "List of items";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Item_Price);
            this.Controls.Add(this.TXT_Item_Price);
            this.Controls.Add(this.LB_Tax_Rate);
            this.Controls.Add(this.TXT_Tax_Rate);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.DGV_Items);
            this.Controls.Add(this.BTN_Calculate_Total);
            this.Controls.Add(this.LB_Subtotal);
            this.Controls.Add(this.LB_Subtotal_Value);
            this.Controls.Add(this.LB_Tax_Amount);
            this.Controls.Add(this.LB_Tax_Amount_Value);
            this.Controls.Add(this.LB_Final_Total);
            this.Controls.Add(this.LB_Final_Total_Value);
            this.Name = "Form1";
            this.Text = "Tax Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Item_Price;
        private System.Windows.Forms.TextBox TXT_Item_Price;
        private System.Windows.Forms.Label LB_Tax_Rate;
        private System.Windows.Forms.TextBox TXT_Tax_Rate;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.DataGridView DGV_Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Tax_Rate;
        private System.Windows.Forms.Button BTN_Calculate_Total;
        private System.Windows.Forms.Label LB_Subtotal;
        private System.Windows.Forms.Label LB_Subtotal_Value;
        private System.Windows.Forms.Label LB_Tax_Amount;
        private System.Windows.Forms.Label LB_Tax_Amount_Value;
        private System.Windows.Forms.Label LB_Final_Total;
        private System.Windows.Forms.Label LB_Final_Total_Value;
        private System.Windows.Forms.Label label1;
    }
}

