using System;
using System.Windows.Forms;

namespace Info_Reg_System.Forms
{
    partial class FormViewAll
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewAll));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kidsInfoDbDataSet = new Info_Reg_System.KidsInfoDbDataSet();
            this.kidsRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kidsRegistrationTableAdapter = new Info_Reg_System.KidsInfoDbDataSetTableAdapters.KidsRegistrationTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.rjTextBoxSearch = new CustomControls.RJControls.RJTextBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjButtonDelete = new CustomControls.RJControls.RJButton();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.pictureBoxExitViewAll = new System.Windows.Forms.PictureBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.rjButtonEdit = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kidsInfoDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kidsRegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExitViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(646, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // kidsInfoDbDataSet
            // 
            this.kidsInfoDbDataSet.DataSetName = "KidsInfoDbDataSet";
            this.kidsInfoDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kidsRegistrationBindingSource
            // 
            this.kidsRegistrationBindingSource.DataMember = "KidsRegistration";
            this.kidsRegistrationBindingSource.DataSource = this.kidsInfoDbDataSet;
            // 
            // kidsRegistrationTableAdapter
            // 
            this.kidsRegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // rjTextBoxSearch
            // 
            this.rjTextBoxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBoxSearch.BorderColor = System.Drawing.Color.LightCoral;
            this.rjTextBoxSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBoxSearch.BorderRadius = 10;
            this.rjTextBoxSearch.BorderSize = 2;
            this.rjTextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxSearch.Location = new System.Drawing.Point(99, 54);
            this.rjTextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxSearch.Multiline = false;
            this.rjTextBoxSearch.Name = "rjTextBoxSearch";
            this.rjTextBoxSearch.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBoxSearch.PasswordChar = false;
            this.rjTextBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxSearch.PlaceholderText = "";
            this.rjTextBoxSearch.Size = new System.Drawing.Size(588, 32);
            this.rjTextBoxSearch.TabIndex = 2;
            this.rjTextBoxSearch.Texts = "";
            this.rjTextBoxSearch.UnderlinedStyle = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.LightCoral;
            this.rjButton1.BackgroundColor = System.Drawing.Color.LightCoral;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(689, 56);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(89, 29);
            this.rjButton1.TabIndex = 3;
            this.rjButton1.Text = "Search";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButtonDelete
            // 
            this.rjButtonDelete.BackColor = System.Drawing.Color.LightCoral;
            this.rjButtonDelete.BackgroundColor = System.Drawing.Color.LightCoral;
            this.rjButtonDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonDelete.BorderRadius = 10;
            this.rjButtonDelete.BorderSize = 0;
            this.rjButtonDelete.FlatAppearance.BorderSize = 0;
            this.rjButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonDelete.ForeColor = System.Drawing.Color.White;
            this.rjButtonDelete.Location = new System.Drawing.Point(689, 166);
            this.rjButtonDelete.Name = "rjButtonDelete";
            this.rjButtonDelete.Size = new System.Drawing.Size(89, 29);
            this.rjButtonDelete.TabIndex = 5;
            this.rjButtonDelete.Text = "Delete";
            this.rjButtonDelete.TextColor = System.Drawing.Color.White;
            this.rjButtonDelete.UseVisualStyleBackColor = false;
            this.rjButtonDelete.Click += new System.EventHandler(this.rjButtonDelete_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // pictureBoxExitViewAll
            // 
            this.pictureBoxExitViewAll.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExitViewAll.Image")));
            this.pictureBoxExitViewAll.Location = new System.Drawing.Point(748, 12);
            this.pictureBoxExitViewAll.Name = "pictureBoxExitViewAll";
            this.pictureBoxExitViewAll.Size = new System.Drawing.Size(30, 18);
            this.pictureBoxExitViewAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExitViewAll.TabIndex = 19;
            this.pictureBoxExitViewAll.TabStop = false;
            this.pictureBoxExitViewAll.Click += new System.EventHandler(this.pictureBoxExitViewAll_Click);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.rjButtonEdit.ForeColor = System.Drawing.Color.White;
            this.rjButtonEdit.Location = new System.Drawing.Point(689, 131);
            this.rjButtonEdit.Name = "rjButtonEdit";
            this.rjButtonEdit.Size = new System.Drawing.Size(89, 29);
            this.rjButtonEdit.TabIndex = 21;
            this.rjButtonEdit.Text = "Edit";
            this.rjButtonEdit.TextColor = System.Drawing.Color.White;
            this.rjButtonEdit.UseVisualStyleBackColor = false;
            this.rjButtonEdit.Click += new System.EventHandler(this.rjButtonEdit_Click);
            // 
            // FormViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.rjButtonEdit);
            this.Controls.Add(this.pictureBoxExitViewAll);
            this.Controls.Add(this.rjButtonDelete);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rjTextBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormViewAll";
            this.Text = "Kids Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormViewAll_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kidsInfoDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kidsRegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExitViewAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private KidsInfoDbDataSet kidsInfoDbDataSet;
        private System.Windows.Forms.BindingSource kidsRegistrationBindingSource;
        private KidsInfoDbDataSetTableAdapters.KidsRegistrationTableAdapter kidsRegistrationTableAdapter;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox rjTextBoxSearch;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButtonDelete;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.PictureBox pictureBoxExitViewAll;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private CustomControls.RJControls.RJButton rjButtonEdit;
    }
}