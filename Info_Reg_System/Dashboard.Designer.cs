using System;
using System.Windows.Forms;

namespace Info_Reg_System
{
    partial class Dashborad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashborad));
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panelDeskTopPane = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButtonSubmit = new CustomControls.RJControls.RJButton();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.textName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panelDeskTopPane.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(828, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(25, 66);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 18;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // panelDeskTopPane
            // 
            this.panelDeskTopPane.Controls.Add(this.panel2);
            this.panelDeskTopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTopPane.Location = new System.Drawing.Point(0, 0);
            this.panelDeskTopPane.Name = "panelDeskTopPane";
            this.panelDeskTopPane.Size = new System.Drawing.Size(853, 559);
            this.panelDeskTopPane.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panelLogo);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 559);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 82);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(370, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Celebrant Information";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.Control;
            this.panelLogo.Controls.Add(this.label9);
            this.panelLogo.Controls.Add(this.pictureBoxExit);
            this.panelLogo.Controls.Add(this.pictureBox3);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(853, 66);
            this.panelLogo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(74, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kids Zone.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBoxAge);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.rjButtonSubmit);
            this.panel4.Controls.Add(this.comboBoxGender);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.dateTimeBirthday);
            this.panel4.Controls.Add(this.textName);
            this.panel4.Location = new System.Drawing.Point(222, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 364);
            this.panel4.TabIndex = 8;
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxAge.Location = new System.Drawing.Point(17, 139);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(365, 28);
            this.comboBoxAge.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // rjButtonSubmit
            // 
            this.rjButtonSubmit.BackColor = System.Drawing.Color.LightCoral;
            this.rjButtonSubmit.BackgroundColor = System.Drawing.Color.LightCoral;
            this.rjButtonSubmit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonSubmit.BorderRadius = 0;
            this.rjButtonSubmit.BorderSize = 0;
            this.rjButtonSubmit.FlatAppearance.BorderSize = 0;
            this.rjButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonSubmit.ForeColor = System.Drawing.Color.White;
            this.rjButtonSubmit.Location = new System.Drawing.Point(122, 247);
            this.rjButtonSubmit.Name = "rjButtonSubmit";
            this.rjButtonSubmit.Size = new System.Drawing.Size(179, 40);
            this.rjButtonSubmit.TabIndex = 1;
            this.rjButtonSubmit.Text = "Submit";
            this.rjButtonSubmit.TextColor = System.Drawing.Color.White;
            this.rjButtonSubmit.UseVisualStyleBackColor = false;
            this.rjButtonSubmit.Click += new System.EventHandler(this.rjButtonSubmit_Click_1);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(18, 85);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(365, 28);
            this.comboBoxGender.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 115);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 168);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Birthday";
            // 
            // dateTimeBirthday
            // 
            this.dateTimeBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBirthday.Location = new System.Drawing.Point(18, 192);
            this.dateTimeBirthday.Name = "dateTimeBirthday";
            this.dateTimeBirthday.Size = new System.Drawing.Size(365, 26);
            this.dateTimeBirthday.TabIndex = 12;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(18, 36);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(365, 26);
            this.textName.TabIndex = 9;
            // 
            // Dashborad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 559);
            this.Controls.Add(this.panelDeskTopPane);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashborad";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashBoard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panelDeskTopPane.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDeskTopPane;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeBirthday;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJButton rjButtonSubmit;
    }
}