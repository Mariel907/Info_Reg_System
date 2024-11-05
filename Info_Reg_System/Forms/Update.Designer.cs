namespace Info_Reg_System.Forms
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rjButtonEdit = new CustomControls.RJControls.RJButton();
            this.cmbBoxAge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Person ID";
            // 
            // txtBoxID
            // 
            this.txtBoxID.BackColor = System.Drawing.Color.White;
            this.txtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxID.Location = new System.Drawing.Point(19, 32);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.Size = new System.Drawing.Size(365, 26);
            this.txtBoxID.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 75);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(370, 39);
            this.label4.TabIndex = 20;
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
            this.panelLogo.Size = new System.Drawing.Size(853, 56);
            this.panelLogo.TabIndex = 19;
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
            // pictureBoxExit
            // 
            this.pictureBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(828, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(25, 56);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 18;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
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
            this.panel4.Controls.Add(this.rjButtonEdit);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtBoxID);
            this.panel4.Controls.Add(this.cmbBoxAge);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cmbBoxGender);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.dtTimeBirthday);
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Location = new System.Drawing.Point(222, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 364);
            this.panel4.TabIndex = 21;
            // 
            // rjButtonEdit
            // 
            this.rjButtonEdit.BackColor = System.Drawing.Color.LightCoral;
            this.rjButtonEdit.BackgroundColor = System.Drawing.Color.LightCoral;
            this.rjButtonEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonEdit.BorderRadius = 10;
            this.rjButtonEdit.BorderSize = 0;
            this.rjButtonEdit.FlatAppearance.BorderSize = 0;
            this.rjButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonEdit.ForeColor = System.Drawing.Color.White;
            this.rjButtonEdit.Location = new System.Drawing.Point(155, 288);
            this.rjButtonEdit.Name = "rjButtonEdit";
            this.rjButtonEdit.Size = new System.Drawing.Size(118, 37);
            this.rjButtonEdit.TabIndex = 22;
            this.rjButtonEdit.Text = "Save";
            this.rjButtonEdit.TextColor = System.Drawing.Color.White;
            this.rjButtonEdit.UseVisualStyleBackColor = false;
            this.rjButtonEdit.Click += new System.EventHandler(this.rjButtonEdit_Click);
            // 
            // cmbBoxAge
            // 
            this.cmbBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxAge.FormattingEnabled = true;
            this.cmbBoxAge.Items.AddRange(new object[] {
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
            this.cmbBoxAge.Location = new System.Drawing.Point(19, 187);
            this.cmbBoxAge.Name = "cmbBoxAge";
            this.cmbBoxAge.Size = new System.Drawing.Size(365, 28);
            this.cmbBoxAge.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxGender.FormattingEnabled = true;
            this.cmbBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBoxGender.Location = new System.Drawing.Point(20, 133);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(365, 28);
            this.cmbBoxGender.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 110);
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
            this.label2.Location = new System.Drawing.Point(11, 163);
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
            this.label6.Location = new System.Drawing.Point(11, 216);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Birthday";
            // 
            // dtTimeBirthday
            // 
            this.dtTimeBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTimeBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTimeBirthday.Location = new System.Drawing.Point(20, 240);
            this.dtTimeBirthday.Name = "dtTimeBirthday";
            this.dtTimeBirthday.Size = new System.Drawing.Size(365, 26);
            this.dtTimeBirthday.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(20, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(365, 26);
            this.txtName.TabIndex = 9;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 559);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panel4);
            this.Name = "Update";
            this.Text = "Update";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUpdate_FormClosing);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbBoxAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtTimeBirthday;
        private System.Windows.Forms.TextBox txtName;
        private CustomControls.RJControls.RJButton rjButtonEdit;
    }
}