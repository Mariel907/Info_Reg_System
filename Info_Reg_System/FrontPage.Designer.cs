using System.Windows.Forms;

namespace Info_Reg_System
{
    partial class FrontPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKidsParty = new System.Windows.Forms.Label();
            this.btnBookNow = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxChangeTheme = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChangeTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 125);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(382, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to the Ultimate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 201);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(375, 61);
            this.label3.TabIndex = 2;
            this.label3.Text = "To create unforgettable, joy-filled celebrations that spark\r\nimagination and deli" +
    "ght for children of all ages, fostering \r\n      a sense of wonder and creating l" +
    "asting memories.";
            // 
            // lblKidsParty
            // 
            this.lblKidsParty.AutoSize = true;
            this.lblKidsParty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKidsParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKidsParty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblKidsParty.Location = new System.Drawing.Point(65, 166);
            this.lblKidsParty.Name = "lblKidsParty";
            this.lblKidsParty.Padding = new System.Windows.Forms.Padding(5);
            this.lblKidsParty.Size = new System.Drawing.Size(291, 39);
            this.lblKidsParty.TabIndex = 3;
            this.lblKidsParty.Text = "Kids\'  Party Destination";
            // 
            // btnBookNow
            // 
            this.btnBookNow.BackColor = System.Drawing.Color.LightCoral;
            this.btnBookNow.FlatAppearance.BorderSize = 0;
            this.btnBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookNow.Location = new System.Drawing.Point(135, 271);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Padding = new System.Windows.Forms.Padding(3);
            this.btnBookNow.Size = new System.Drawing.Size(114, 35);
            this.btnBookNow.TabIndex = 4;
            this.btnBookNow.Text = "Book Now";
            this.btnBookNow.UseVisualStyleBackColor = false;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.LightCoral;
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(135, 312);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Padding = new System.Windows.Forms.Padding(3);
            this.btnViewAll.Size = new System.Drawing.Size(114, 35);
            this.btnViewAll.TabIndex = 7;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxChangeTheme);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnBookNow);
            this.panel1.Controls.Add(this.btnViewAll);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblKidsParty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 452);
            this.panel1.TabIndex = 8;
            // 
            // pictureBoxChangeTheme
            // 
            this.pictureBoxChangeTheme.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChangeTheme.Image")));
            this.pictureBoxChangeTheme.Location = new System.Drawing.Point(341, 15);
            this.pictureBoxChangeTheme.Name = "pictureBoxChangeTheme";
            this.pictureBoxChangeTheme.Size = new System.Drawing.Size(41, 34);
            this.pictureBoxChangeTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChangeTheme.TabIndex = 10;
            this.pictureBoxChangeTheme.TabStop = false;
            this.pictureBoxChangeTheme.Click += new System.EventHandler(this.pictureBoxChangeTheme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kids Zone.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Info_Reg_System.Properties.Resources._13_Sweet_Candy_Land_Theme_Party_Ideas___PartySlate;
            this.pictureBox1.Location = new System.Drawing.Point(372, -65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 575);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrontPage";
            this.Text = " Kids Zone";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrontPage_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChangeTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKidsParty;
        private System.Windows.Forms.Button btnBookNow;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxChangeTheme;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}