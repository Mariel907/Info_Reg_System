using Info_Reg_System.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Info_Reg_System
{
    public partial class FrontPage : Form
    {
        bool isBoyMode = false;

        public FrontPage()
        {
            InitializeComponent();
            InitializeTheme();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeTheme()
        {
            if (isBoyMode)
            {
                BoyMode();
            }
            else
            {
                GirlMode();
            }
        }

        private void GirlMode()
        {
            btnBookNow.BackColor = Color.LightCoral;
            btnViewAll.BackColor = Color.LightCoral;
            pictureBox1.Image = Properties.Resources._13_Sweet_Candy_Land_Theme_Party_Ideas___PartySlate;
            lblKidsParty.ForeColor = Color.LightCoral;
        }

        private void BoyMode()
        {
            btnBookNow.BackColor = Color.DeepSkyBlue;
            btnViewAll.BackColor = Color.DeepSkyBlue;
            pictureBox1.Image = Properties.Resources.download__1_;
            lblKidsParty.ForeColor = Color.DeepSkyBlue;
        }

        private void pictureBoxChangeTheme_Click(object sender, EventArgs e)
        {
            isBoyMode = !isBoyMode;
            InitializeTheme();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            Dashborad dashboard = new Dashborad();
            dashboard.Show();

            this.Hide();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            FormViewAll formViewAll = new FormViewAll();
            formViewAll.Show();

            this.Hide();
        }
        private void FrontPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
