using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Info_Reg_System.Forms
{
    public partial class Update : Form
    {
        public Update(string id, string name, string gender, string age, DateTime birthday)
        {
            InitializeComponent();
            txtBoxID.Text = id;
            txtName.Text = name; 
            cmbBoxGender.Text = gender; 
            cmbBoxAge.Text = age; 
            dtTimeBirthday.Value = birthday;

            this.StartPosition = FormStartPosition.CenterScreen;
        }
       
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            FormViewAll formView = new FormViewAll();
            formView.Show();

            this.Hide();
        }
        
        private void FormUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rjButtonEdit_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local);Initial Catalog=KidsInfoDb;Integrated Security=True;Encrypt=False";
            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            try
            {
                mySqlConnection.Open();

                int Id = int.Parse(txtBoxID.Text);
                string Kid_Name = txtName.Text;
                string Kid_Gender = cmbBoxGender.Text;
                int Age = int.Parse(cmbBoxAge.Text);
                DateTime Birthday = dtTimeBirthday.Value;

                string query = @"UPDATE KidsRegistration 
                                 SET Name=@Name, Gender=@Gender, Age=@Age, Birthday=@Birthday 
                                 WHERE Person_ID=@Id;";

                using (SqlCommand cmd = new SqlCommand(query, mySqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Name", Kid_Name);
                    cmd.Parameters.AddWithValue("@Gender", Kid_Gender);
                    cmd.Parameters.AddWithValue("@Age", Age);
                    cmd.Parameters.AddWithValue("@Birthday", Birthday);
                    cmd.Parameters.AddWithValue("@Id", Id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully!");
                }
            }
            catch (SqlException h)
            {
                MessageBox.Show(h.ToString());
            }
        }
    }

}

