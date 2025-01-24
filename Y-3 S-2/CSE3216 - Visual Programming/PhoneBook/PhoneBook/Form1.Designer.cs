namespace PhoneBook
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbHomeAddress = new System.Windows.Forms.Label();
            this.tbBusinessAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.lbMobile = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.tbHomeAddress = new System.Windows.Forms.TextBox();
            this.tbMname = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.lbBusinessAddress = new System.Windows.Forms.Label();
            this.lbMname = new System.Windows.Forms.Label();
            this.lbFname = new System.Windows.Forms.Label();
            this.lbLname = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(119, 35);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(647, 22);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbHomeAddress);
            this.groupBox1.Controls.Add(this.tbBusinessAddress);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.tbMobile);
            this.groupBox1.Controls.Add(this.lbMobile);
            this.groupBox1.Controls.Add(this.tbTelephone);
            this.groupBox1.Controls.Add(this.lbTelephone);
            this.groupBox1.Controls.Add(this.tbHomeAddress);
            this.groupBox1.Controls.Add(this.tbMname);
            this.groupBox1.Controls.Add(this.tbFname);
            this.groupBox1.Controls.Add(this.tbLname);
            this.groupBox1.Controls.Add(this.lbBusinessAddress);
            this.groupBox1.Controls.Add(this.lbMname);
            this.groupBox1.Controls.Add(this.lbFname);
            this.groupBox1.Controls.Add(this.lbLname);
            this.groupBox1.Location = new System.Drawing.Point(38, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 211);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lbHomeAddress
            // 
            this.lbHomeAddress.AutoSize = true;
            this.lbHomeAddress.ForeColor = System.Drawing.Color.White;
            this.lbHomeAddress.Location = new System.Drawing.Point(6, 137);
            this.lbHomeAddress.Name = "lbHomeAddress";
            this.lbHomeAddress.Size = new System.Drawing.Size(98, 16);
            this.lbHomeAddress.TabIndex = 3;
            this.lbHomeAddress.Text = "Home Address";
            this.lbHomeAddress.Click += new System.EventHandler(this.lbHomeAddress_Click);
            // 
            // tbBusinessAddress
            // 
            this.tbBusinessAddress.Location = new System.Drawing.Point(128, 173);
            this.tbBusinessAddress.Name = "tbBusinessAddress";
            this.tbBusinessAddress.Size = new System.Drawing.Size(495, 22);
            this.tbBusinessAddress.TabIndex = 8;
            this.tbBusinessAddress.TextChanged += new System.EventHandler(this.tbBusinessAddress_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(444, 97);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(179, 22);
            this.tbEmail.TabIndex = 13;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(326, 97);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 16);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email";
            this.lbEmail.Click += new System.EventHandler(this.lbEmail_Click);
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(444, 60);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(179, 22);
            this.tbMobile.TabIndex = 11;
            this.tbMobile.TextChanged += new System.EventHandler(this.tbMobile_TextChanged);
            // 
            // lbMobile
            // 
            this.lbMobile.AutoSize = true;
            this.lbMobile.ForeColor = System.Drawing.Color.White;
            this.lbMobile.Location = new System.Drawing.Point(326, 63);
            this.lbMobile.Name = "lbMobile";
            this.lbMobile.Size = new System.Drawing.Size(58, 16);
            this.lbMobile.TabIndex = 10;
            this.lbMobile.Text = "Mobile #";
            this.lbMobile.Click += new System.EventHandler(this.lbMobile_Click);
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(444, 25);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(179, 22);
            this.tbTelephone.TabIndex = 9;
            this.tbTelephone.TextChanged += new System.EventHandler(this.tbTelephone_TextChanged);
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.ForeColor = System.Drawing.Color.White;
            this.lbTelephone.Location = new System.Drawing.Point(326, 28);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(83, 16);
            this.lbTelephone.TabIndex = 8;
            this.lbTelephone.Text = "Telephone #";
            this.lbTelephone.Click += new System.EventHandler(this.lbTelephone_Click);
            // 
            // tbHomeAddress
            // 
            this.tbHomeAddress.Location = new System.Drawing.Point(128, 134);
            this.tbHomeAddress.Name = "tbHomeAddress";
            this.tbHomeAddress.Size = new System.Drawing.Size(495, 22);
            this.tbHomeAddress.TabIndex = 3;
            this.tbHomeAddress.TextChanged += new System.EventHandler(this.tbHomeAddress_TextChanged);
            // 
            // tbMname
            // 
            this.tbMname.Location = new System.Drawing.Point(128, 97);
            this.tbMname.Name = "tbMname";
            this.tbMname.Size = new System.Drawing.Size(179, 22);
            this.tbMname.TabIndex = 7;
            this.tbMname.TextChanged += new System.EventHandler(this.tbMname_TextChanged);
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(128, 60);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(179, 22);
            this.tbFname.TabIndex = 6;
            this.tbFname.TextChanged += new System.EventHandler(this.tbFname_TextChanged);
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(128, 22);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(179, 22);
            this.tbLname.TabIndex = 5;
            this.tbLname.TextChanged += new System.EventHandler(this.tbLname_TextChanged);
            // 
            // lbBusinessAddress
            // 
            this.lbBusinessAddress.AutoSize = true;
            this.lbBusinessAddress.ForeColor = System.Drawing.Color.White;
            this.lbBusinessAddress.Location = new System.Drawing.Point(6, 176);
            this.lbBusinessAddress.Name = "lbBusinessAddress";
            this.lbBusinessAddress.Size = new System.Drawing.Size(116, 16);
            this.lbBusinessAddress.TabIndex = 4;
            this.lbBusinessAddress.Text = "Business Address";
            this.lbBusinessAddress.Click += new System.EventHandler(this.lbBusinessAddress_Click);
            // 
            // lbMname
            // 
            this.lbMname.AutoSize = true;
            this.lbMname.ForeColor = System.Drawing.Color.White;
            this.lbMname.Location = new System.Drawing.Point(6, 100);
            this.lbMname.Name = "lbMname";
            this.lbMname.Size = new System.Drawing.Size(72, 16);
            this.lbMname.TabIndex = 2;
            this.lbMname.Text = "Mid. Name";
            this.lbMname.Click += new System.EventHandler(this.lbMname_Click);
            // 
            // lbFname
            // 
            this.lbFname.AutoSize = true;
            this.lbFname.ForeColor = System.Drawing.Color.White;
            this.lbFname.Location = new System.Drawing.Point(6, 63);
            this.lbFname.Name = "lbFname";
            this.lbFname.Size = new System.Drawing.Size(72, 16);
            this.lbFname.TabIndex = 1;
            this.lbFname.Text = "First Name";
            this.lbFname.Click += new System.EventHandler(this.lbFname_Click);
            // 
            // lbLname
            // 
            this.lbLname.AutoSize = true;
            this.lbLname.ForeColor = System.Drawing.Color.White;
            this.lbLname.Location = new System.Drawing.Point(6, 25);
            this.lbLname.Name = "lbLname";
            this.lbLname.Size = new System.Drawing.Size(72, 16);
            this.lbLname.TabIndex = 0;
            this.lbLname.Text = "Last Name";
            this.lbLname.Click += new System.EventHandler(this.lbLname_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Moccasin;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAdd.Location = new System.Drawing.Point(691, 80);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 37);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Moccasin;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btEdit.Location = new System.Drawing.Point(691, 152);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 37);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Moccasin;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btDelete.Location = new System.Drawing.Point(691, 218);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 37);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(38, 35);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 7;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(728, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbBusinessAddress;
        private System.Windows.Forms.Label lbHomeAddress;
        private System.Windows.Forms.Label lbMname;
        private System.Windows.Forms.Label lbFname;
        private System.Windows.Forms.Label lbLname;
        private System.Windows.Forms.TextBox tbHomeAddress;
        private System.Windows.Forms.TextBox tbMname;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbBusinessAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Label lbMobile;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

