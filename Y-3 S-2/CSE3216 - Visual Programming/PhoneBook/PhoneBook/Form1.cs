using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
            ClearFields();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=PhoneBook;Trusted_Connection=True;";

        private void btSearch_Click(object sender, EventArgs e)
        {
            LoadData(tbSearch.Text.Trim());
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(tbSearch.Text.Trim());
        }

        private void lbLname_Click(object sender, EventArgs e)
        {

        }

        private void tbLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTelephone_Click(object sender, EventArgs e)
        {

        }

        private void tbTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbFname_Click(object sender, EventArgs e)
        {

        }

        private void tbFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMobile_Click(object sender, EventArgs e)
        {

        }

        private void tbMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMname_Click(object sender, EventArgs e)
        {

        }

        private void tbMname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbHomeAddress_Click(object sender, EventArgs e)
        {

        }

        private void tbHomeAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbBusinessAddress_Click(object sender, EventArgs e)
        {

        }

        private void tbBusinessAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO PhoneBook (FirstName, MiddleName, LastName, HomeAddress, BusinessAddress, Telephone, Mobile, Email) " +
                               "VALUES (@FName, @MName, @LName, @HomeAddr, @BusAddr, @Telephone, @Mobile, @Email)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FName", tbFname.Text);
                    cmd.Parameters.AddWithValue("@MName", tbMname.Text);
                    cmd.Parameters.AddWithValue("@LName", tbLname.Text);
                    cmd.Parameters.AddWithValue("@HomeAddr", tbHomeAddress.Text);
                    cmd.Parameters.AddWithValue("@BusAddr", tbBusinessAddress.Text);
                    cmd.Parameters.AddWithValue("@Telephone", tbTelephone.Text);
                    cmd.Parameters.AddWithValue("@Mobile", tbMobile.Text);
                    cmd.Parameters.AddWithValue("@Email", tbEmail.Text);

                    cmd.ExecuteNonQuery();
                }
            }
            ClearFields();
            LoadData();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            int selectedRowId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE PhoneBook SET FirstName = @FName, MiddleName = @MName, LastName = @LName, " +
                               "HomeAddress = @HomeAddr, BusinessAddress = @BusAddr, Telephone = @Telephone, " +
                               "Mobile = @Mobile, Email = @Email WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", selectedRowId);
                    cmd.Parameters.AddWithValue("@FName", tbFname.Text);
                    cmd.Parameters.AddWithValue("@MName", tbMname.Text);
                    cmd.Parameters.AddWithValue("@LName", tbLname.Text);
                    cmd.Parameters.AddWithValue("@HomeAddr", tbHomeAddress.Text);
                    cmd.Parameters.AddWithValue("@BusAddr", tbBusinessAddress.Text);
                    cmd.Parameters.AddWithValue("@Telephone", tbTelephone.Text);
                    cmd.Parameters.AddWithValue("@Mobile", tbMobile.Text);
                    cmd.Parameters.AddWithValue("@Email", tbEmail.Text);

                    cmd.ExecuteNonQuery();
                }
            }
            ClearFields();
            LoadData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            int selectedRowId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM PhoneBook WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", selectedRowId);
                    cmd.ExecuteNonQuery();
                }
            }
            ClearFields();
            LoadData();
        }
        private void LoadData(string search = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                Id,
                CASE 
                    WHEN LastName IS NOT NULL AND LastName <> '' 
                    THEN LastName + ', ' + FirstName + ' ' + COALESCE(MiddleName, '') 
                    ELSE FirstName + ' ' + COALESCE(MiddleName, '') 
                END AS Name,
                HomeAddress,
                BusinessAddress,
                Telephone,
                Mobile,
                Email
            FROM PhoneBook
            WHERE 
                FirstName LIKE @Search OR 
                LastName LIKE @Search OR 
                Mobile LIKE @Search";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Search", $"%{search}%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }


        private void ClearFields()
        {
            tbFname.Clear();
            tbMname.Clear();
            tbLname.Clear();
            tbHomeAddress.Clear();
            tbBusinessAddress.Clear();
            tbTelephone.Clear();
            tbMobile.Clear();
            tbEmail.Clear();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells["Id"].Value != DBNull.Value && selectedRow.Cells["Id"].Value != null)
                {
                    // Parse FullName to separate parts
                    string fullName = selectedRow.Cells["Name"].Value?.ToString().Trim();
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        ClearFields();
                        var nameParts = fullName.Split(new[] { ',' }, 2); // Split by comma
                        if (nameParts.Length > 1)
                        {
                            tbLname.Text = nameParts[0]?.Trim(); // LastName
                            var firstMiddle = nameParts[1]?.Trim().Split(' '); // Split FirstName and MiddleName
                            tbFname.Text = firstMiddle[0]?.Trim();
                            tbMname.Text = firstMiddle.Length > 1 ? firstMiddle[1]?.Trim() : string.Empty;
                        }
                    }

                    tbHomeAddress.Text = selectedRow.Cells["HomeAddress"].Value?.ToString().Trim();
                    tbBusinessAddress.Text = selectedRow.Cells["BusinessAddress"].Value?.ToString().Trim();
                    tbTelephone.Text = selectedRow.Cells["Telephone"].Value?.ToString().Trim();
                    tbMobile.Text = selectedRow.Cells["Mobile"].Value?.ToString().Trim();
                    tbEmail.Text = selectedRow.Cells["Email"].Value?.ToString().Trim();
                }
                else
                {
                    ClearFields();
                }
            }
            else
            {
                ClearFields();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearFields();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells["Id"].Value != DBNull.Value && selectedRow.Cells["Id"].Value != null)
                {
                    // Parse FullName to separate parts
                    string fullName = selectedRow.Cells["Name"].Value?.ToString().Trim();
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        var nameParts = fullName.Split(new[] { ',' }, 2); // Split by comma
                        if (nameParts.Length > 1)
                        {
                            tbLname.Text = nameParts[0]?.Trim(); // LastName
                            var firstMiddle = nameParts[1]?.Trim().Split(' '); // Split FirstName and MiddleName
                            tbFname.Text = firstMiddle[0]?.Trim();
                            tbMname.Text = firstMiddle.Length > 1 ? firstMiddle[1]?.Trim() : string.Empty;
                        }
                    }

                    tbHomeAddress.Text = selectedRow.Cells["HomeAddress"].Value?.ToString().Trim();
                    tbBusinessAddress.Text = selectedRow.Cells["BusinessAddress"].Value?.ToString().Trim();
                    tbTelephone.Text = selectedRow.Cells["Telephone"].Value?.ToString().Trim();
                    tbMobile.Text = selectedRow.Cells["Mobile"].Value?.ToString().Trim();
                    tbEmail.Text = selectedRow.Cells["Email"].Value?.ToString().Trim();
                }
                else
                {
                    ClearFields();
                }
            }
            else
            {
                ClearFields();
            }
        }
    }
}
