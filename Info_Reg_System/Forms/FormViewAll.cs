using Mysqlx;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Info_Reg_System.Forms
{
    public partial class FormViewAll : Form
    {
        private string connectionString = "Data Source=(local);Initial Catalog=KidsInfoDb;Integrated Security=True;Encrypt=False";

        public FormViewAll()
        {
            InitializeComponent();
            LoadData();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM KidsRegistration";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }
        }

        private void pictureBoxExitViewAll_Click(object sender, System.EventArgs e)
        {
            FrontPage frontPage = new FrontPage();
            frontPage.Show();

            this.Hide();
        }
        #region Reset
        //public void ResetIDs()
        //{
        //    string connectionString = "Data Source=(local);Initial Catalog=KidsInfoDb;Integrated Security=True;Encrypt=False";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            // Get all remaining records
        //            string selectQuery = "SELECT * FROM KidsRegistration ORDER BY Person_ID";
        //            DataTable dataTable = new DataTable();
        //            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection))
        //            {
        //                dataAdapter.Fill(dataTable);
        //            }

        //            // Truncate the table to reset IDs
        //            string truncateQuery = "TRUNCATE TABLE KidsRegistration";
        //            using (SqlCommand truncateCmd = new SqlCommand(truncateQuery, connection))
        //            {
        //                truncateCmd.ExecuteNonQuery();
        //            }

        //            // Reinsert records with new IDs starting from 1
        //            foreach (DataRow row in dataTable.Rows)
        //            {
        //                string reinsertQuery = "INSERT INTO KidsRegistration (Name, Gender, Age, Birthday) VALUES (@Name, @Gender, @Age, @Birthday)";
        //                using (SqlCommand reinsertCmd = new SqlCommand(reinsertQuery, connection))
        //                {
        //                    reinsertCmd.Parameters.AddWithValue("@Name", row["Name"]);
        //                    reinsertCmd.Parameters.AddWithValue("@Gender", row["Gender"]);
        //                    reinsertCmd.Parameters.AddWithValue("@Age", row["Age"]);
        //                    reinsertCmd.Parameters.AddWithValue("@Birthday", row["Birthday"]);
        //                    reinsertCmd.ExecuteNonQuery();
        //                }
        //            }
        //        }
        //        catch (SqlException ex)
        //        {
        //            MessageBox.Show("SQL Error: " + ex.Message);
        //        }
        //    }
        //}
        #endregion
        public void DeleteRecord(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM KidsRegistration WHERE Person_ID = @ID";
                    using (SqlCommand deletecmd = new SqlCommand(deleteQuery, connection))
                    {
                        deletecmd.Parameters.AddWithValue("@ID", id);
                        deletecmd.ExecuteNonQuery();
                    }

                    #region Reseed
                    //            string maxIdQuery = "SELECT ISNULL(MAX(Person_ID), 0) FROM KidsRegistration";
                    //            using (SqlCommand maxIdCmd = new SqlCommand(maxIdQuery, connection))
                    //            {
                    //                int maxId = (int)maxIdCmd.ExecuteScalar();
                    //                string reseedQuery = $"DBCC CHECKIDENT ('KidsRegistration', RESEED, {maxId})";
                    //                using (SqlCommand reseedCmd = new SqlCommand(reseedQuery, connection))
                    //                {
                    //                    reseedCmd.ExecuteNonQuery();
                    //                }
                    //            }
                    #endregion

                    MessageBox.Show("Record deleted successfully!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }
        }

        private void rjButtonDelete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {

                    int idToDelete = (int)dataGridView1.SelectedRows[0].Cells["Person_ID"].Value;
                    DeleteRecord(idToDelete);

                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void FormViewAll_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region ResetButton
        //private void rjButtonReset_Click(object sender, System.EventArgs e)
        //{
        //    ResetIDs();
        //    LoadData();
        //}
        #endregion

        private void rjButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string id = selectedRow.Cells["Person_ID"].Value.ToString();
                    string name = selectedRow.Cells["Name"].Value.ToString();
                    string gender = selectedRow.Cells["Gender"].Value.ToString();
                    string age = selectedRow.Cells["Age"].Value.ToString();
                    DateTime birthday = Convert.ToDateTime(selectedRow.Cells["Birthday"].Value);
                    Update updateForm = new Update(id, name, gender, age, birthday);
                    updateForm.Show(); this.Hide();
                }
                else
                { MessageBox.Show("Please select a row to update."); }
            }
            catch (SqlException m)
            {
                MessageBox.Show(m.ToString());
            }
        }
    }
}
