using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Info_Reg_System
{
    public partial class Dashborad : Form
    {
        private Form activeForm;
       
        public Dashborad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    
        #region NOUsed

        //private void OpenChildForm(Form ChildForm, object btnSender)
        //{
        //    if (activeForm != null)
        //    {
        //        activeForm.Close();
        //    }
        //    activeForm = ChildForm;
        //    ChildForm.TopLevel = false;
        //    ChildForm.FormBorderStyle = FormBorderStyle.None;
        //    ChildForm.Dock = DockStyle.Fill;
        //    this.panelDeskTopPane.Controls.Add(ChildForm);
        //    this.panelDeskTopPane.Tag = ChildForm;
        //    ChildForm.BringToFront();
        //    ChildForm.Show();
        //}
        //private void btnCelebratorInformation_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormCelebratorInformation(), sender);
        //}
        //private void btnThemePreference_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormThemePreferences(), sender);
        //}
        #endregion
        private void pictureBoxExit_Click(object sender, EventArgs e) 
        {
            FrontPage frontPage = new FrontPage();
            frontPage.Show();

            this.Hide();
        }

        private void rjButtonSubmit_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local);Initial Catalog=KidsInfoDb;Integrated Security=True;Encrypt=False";
            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            try
            {
                mySqlConnection.Open();
                string Kid_Name = textName.Text;
                string Kid_Gender = comboBoxGender.Text;
                int Age = int.Parse(comboBoxAge.Text);
                var Birthday = dateTimeBirthday.Value;

                string Query = $"INSERT INTO KidsRegistration(Name, Gender, Age, Birthday) VALUES (@Name, @Gender, @Age, @BirthDay)";
                using (SqlCommand cmd = new SqlCommand(Query, mySqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Name", Kid_Name);
                    cmd.Parameters.AddWithValue("@Gender", Kid_Gender);
                    cmd.Parameters.AddWithValue("@Age", Age);
                    cmd.Parameters.AddWithValue("@Birthday", Birthday);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record inserted successfully!");

                    textName.Clear();
                    comboBoxGender.SelectedIndex = -1;
                    comboBoxAge.SelectedIndex = -1;
                    dateTimeBirthday.Value = DateTime.Now;

                    textName.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
