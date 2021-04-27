namespace SEN381_Project_Call_Center_Group_8
{
    partial class AdministratorDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewTable = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRemoveAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProfileAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnInsertAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogoutAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdminDashBoard = new System.Windows.Forms.Label();
            this.dgAdminDashboard = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.adminDashboard_INSERT1 = new SEN381_Project_Call_Center_Group_8.PresentationLayer.userControls.AdminDashboard_INSERT();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdminDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnViewTable);
            this.panel1.Controls.Add(this.btnUpdateAdmin);
            this.panel1.Controls.Add(this.btnRemoveAdmin);
            this.panel1.Controls.Add(this.btnProfileAdmin);
            this.panel1.Controls.Add(this.BtnInsertAdmin);
            this.panel1.Controls.Add(this.btnLogoutAdmin);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // btnViewTable
            // 
            this.btnViewTable.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnViewTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnViewTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewTable.BorderRadius = 0;
            this.btnViewTable.ButtonText = "View Table";
            this.btnViewTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewTable.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewTable.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewTable.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnViewTable.Iconimage")));
            this.btnViewTable.Iconimage_right = null;
            this.btnViewTable.Iconimage_right_Selected = null;
            this.btnViewTable.Iconimage_Selected = null;
            this.btnViewTable.IconMarginLeft = 0;
            this.btnViewTable.IconMarginRight = 0;
            this.btnViewTable.IconRightVisible = true;
            this.btnViewTable.IconRightZoom = 0D;
            this.btnViewTable.IconVisible = true;
            this.btnViewTable.IconZoom = 90D;
            this.btnViewTable.IsTab = false;
            this.btnViewTable.Location = new System.Drawing.Point(0, 212);
            this.btnViewTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnViewTable.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnViewTable.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewTable.selected = false;
            this.btnViewTable.Size = new System.Drawing.Size(200, 48);
            this.btnViewTable.TabIndex = 4;
            this.btnViewTable.Text = "View Table";
            this.btnViewTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewTable.Textcolor = System.Drawing.Color.White;
            this.btnViewTable.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTable.Click += new System.EventHandler(this.btnViewTable_Click);
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateAdmin.BorderRadius = 0;
            this.btnUpdateAdmin.ButtonText = "Update";
            this.btnUpdateAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateAdmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateAdmin.Iconimage")));
            this.btnUpdateAdmin.Iconimage_right = null;
            this.btnUpdateAdmin.Iconimage_right_Selected = null;
            this.btnUpdateAdmin.Iconimage_Selected = null;
            this.btnUpdateAdmin.IconMarginLeft = 0;
            this.btnUpdateAdmin.IconMarginRight = 0;
            this.btnUpdateAdmin.IconRightVisible = true;
            this.btnUpdateAdmin.IconRightZoom = 0D;
            this.btnUpdateAdmin.IconVisible = true;
            this.btnUpdateAdmin.IconZoom = 90D;
            this.btnUpdateAdmin.IsTab = false;
            this.btnUpdateAdmin.Location = new System.Drawing.Point(0, 340);
            this.btnUpdateAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdateAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateAdmin.selected = false;
            this.btnUpdateAdmin.Size = new System.Drawing.Size(200, 34);
            this.btnUpdateAdmin.TabIndex = 3;
            this.btnUpdateAdmin.Text = "Update";
            this.btnUpdateAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAdmin.Textcolor = System.Drawing.Color.White;
            this.btnUpdateAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRemoveAdmin
            // 
            this.btnRemoveAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRemoveAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRemoveAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveAdmin.BorderRadius = 0;
            this.btnRemoveAdmin.ButtonText = "Remove";
            this.btnRemoveAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnRemoveAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRemoveAdmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRemoveAdmin.Iconimage")));
            this.btnRemoveAdmin.Iconimage_right = null;
            this.btnRemoveAdmin.Iconimage_right_Selected = null;
            this.btnRemoveAdmin.Iconimage_Selected = null;
            this.btnRemoveAdmin.IconMarginLeft = 0;
            this.btnRemoveAdmin.IconMarginRight = 0;
            this.btnRemoveAdmin.IconRightVisible = true;
            this.btnRemoveAdmin.IconRightZoom = 0D;
            this.btnRemoveAdmin.IconVisible = true;
            this.btnRemoveAdmin.IconZoom = 90D;
            this.btnRemoveAdmin.IsTab = false;
            this.btnRemoveAdmin.Location = new System.Drawing.Point(0, 302);
            this.btnRemoveAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveAdmin.Name = "btnRemoveAdmin";
            this.btnRemoveAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRemoveAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRemoveAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRemoveAdmin.selected = false;
            this.btnRemoveAdmin.Size = new System.Drawing.Size(200, 38);
            this.btnRemoveAdmin.TabIndex = 2;
            this.btnRemoveAdmin.Text = "Remove";
            this.btnRemoveAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveAdmin.Textcolor = System.Drawing.Color.White;
            this.btnRemoveAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnProfileAdmin
            // 
            this.btnProfileAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProfileAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProfileAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfileAdmin.BorderRadius = 0;
            this.btnProfileAdmin.ButtonText = "Profile";
            this.btnProfileAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfileAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnProfileAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProfileAdmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProfileAdmin.Iconimage")));
            this.btnProfileAdmin.Iconimage_right = null;
            this.btnProfileAdmin.Iconimage_right_Selected = null;
            this.btnProfileAdmin.Iconimage_Selected = null;
            this.btnProfileAdmin.IconMarginLeft = 0;
            this.btnProfileAdmin.IconMarginRight = 0;
            this.btnProfileAdmin.IconRightVisible = true;
            this.btnProfileAdmin.IconRightZoom = 0D;
            this.btnProfileAdmin.IconVisible = true;
            this.btnProfileAdmin.IconZoom = 50D;
            this.btnProfileAdmin.IsTab = false;
            this.btnProfileAdmin.Location = new System.Drawing.Point(0, 371);
            this.btnProfileAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProfileAdmin.Name = "btnProfileAdmin";
            this.btnProfileAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProfileAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnProfileAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProfileAdmin.selected = false;
            this.btnProfileAdmin.Size = new System.Drawing.Size(200, 35);
            this.btnProfileAdmin.TabIndex = 0;
            this.btnProfileAdmin.Text = "Profile";
            this.btnProfileAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfileAdmin.Textcolor = System.Drawing.Color.White;
            this.btnProfileAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnInsertAdmin
            // 
            this.BtnInsertAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnInsertAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnInsertAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInsertAdmin.BorderRadius = 0;
            this.BtnInsertAdmin.ButtonText = "Insert";
            this.BtnInsertAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.BtnInsertAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnInsertAdmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnInsertAdmin.Iconimage")));
            this.BtnInsertAdmin.Iconimage_right = null;
            this.BtnInsertAdmin.Iconimage_right_Selected = null;
            this.BtnInsertAdmin.Iconimage_Selected = null;
            this.BtnInsertAdmin.IconMarginLeft = 0;
            this.BtnInsertAdmin.IconMarginRight = 0;
            this.BtnInsertAdmin.IconRightVisible = true;
            this.BtnInsertAdmin.IconRightZoom = 0D;
            this.BtnInsertAdmin.IconVisible = true;
            this.BtnInsertAdmin.IconZoom = 90D;
            this.BtnInsertAdmin.IsTab = false;
            this.BtnInsertAdmin.Location = new System.Drawing.Point(0, 255);
            this.BtnInsertAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInsertAdmin.Name = "BtnInsertAdmin";
            this.BtnInsertAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnInsertAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnInsertAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnInsertAdmin.selected = false;
            this.BtnInsertAdmin.Size = new System.Drawing.Size(200, 48);
            this.BtnInsertAdmin.TabIndex = 1;
            this.BtnInsertAdmin.Text = "Insert";
            this.BtnInsertAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInsertAdmin.Textcolor = System.Drawing.Color.White;
            this.BtnInsertAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertAdmin.Click += new System.EventHandler(this.BtnInsertAdmin_Click);
            // 
            // btnLogoutAdmin
            // 
            this.btnLogoutAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogoutAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogoutAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogoutAdmin.BorderRadius = 0;
            this.btnLogoutAdmin.ButtonText = "Logout";
            this.btnLogoutAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogoutAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogoutAdmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogoutAdmin.Iconimage")));
            this.btnLogoutAdmin.Iconimage_right = null;
            this.btnLogoutAdmin.Iconimage_right_Selected = null;
            this.btnLogoutAdmin.Iconimage_Selected = null;
            this.btnLogoutAdmin.IconMarginLeft = 0;
            this.btnLogoutAdmin.IconMarginRight = 0;
            this.btnLogoutAdmin.IconRightVisible = true;
            this.btnLogoutAdmin.IconRightZoom = 0D;
            this.btnLogoutAdmin.IconVisible = true;
            this.btnLogoutAdmin.IconZoom = 50D;
            this.btnLogoutAdmin.IsTab = false;
            this.btnLogoutAdmin.Location = new System.Drawing.Point(0, 402);
            this.btnLogoutAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogoutAdmin.Name = "btnLogoutAdmin";
            this.btnLogoutAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogoutAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLogoutAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogoutAdmin.selected = false;
            this.btnLogoutAdmin.Size = new System.Drawing.Size(200, 48);
            this.btnLogoutAdmin.TabIndex = 0;
            this.btnLogoutAdmin.Text = "Logout";
            this.btnLogoutAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoutAdmin.Textcolor = System.Drawing.SystemColors.Window;
            this.btnLogoutAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bunifuImageButton1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 161);
            this.panel4.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(200, 162);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblAdminDashBoard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 54);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(552, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // lblAdminDashBoard
            // 
            this.lblAdminDashBoard.AutoSize = true;
            this.lblAdminDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDashBoard.Location = new System.Drawing.Point(205, 9);
            this.lblAdminDashBoard.Name = "lblAdminDashBoard";
            this.lblAdminDashBoard.Size = new System.Drawing.Size(230, 31);
            this.lblAdminDashBoard.TabIndex = 0;
            this.lblAdminDashBoard.Text = "Admin Dashboard";
            // 
            // dgAdminDashboard
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgAdminDashboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgAdminDashboard.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgAdminDashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAdminDashboard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAdminDashboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgAdminDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdminDashboard.DoubleBuffered = true;
            this.dgAdminDashboard.EnableHeadersVisualStyles = false;
            this.dgAdminDashboard.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgAdminDashboard.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgAdminDashboard.Location = new System.Drawing.Point(200, 54);
            this.dgAdminDashboard.Name = "dgAdminDashboard";
            this.dgAdminDashboard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgAdminDashboard.RowHeadersWidth = 62;
            this.dgAdminDashboard.Size = new System.Drawing.Size(600, 396);
            this.dgAdminDashboard.TabIndex = 3;
            this.dgAdminDashboard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAdminDashboard_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // adminDashboard_INSERT1
            // 
            this.adminDashboard_INSERT1.Location = new System.Drawing.Point(162, 9);
            this.adminDashboard_INSERT1.Name = "adminDashboard_INSERT1";
            this.adminDashboard_INSERT1.Size = new System.Drawing.Size(638, 450);
            this.adminDashboard_INSERT1.TabIndex = 4;
            // 
            // AdministratorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.adminDashboard_INSERT1);
            this.Controls.Add(this.dgAdminDashboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministratorDashboard";
            this.Text = "AdministratorDashboard";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdminDashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton btnRemoveAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton btnProfileAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton BtnInsertAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogoutAdmin;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAdminDashBoard;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgAdminDashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private PresentationLayer.userControls.AdminDashboard_INSERT adminDashboard_INSERT1;
    }
}