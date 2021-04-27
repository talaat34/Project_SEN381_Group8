namespace SEN381_Project_Call_Center_Group_8.PresentationLayer.userControls
{
    partial class InsertTechnician
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertTechnician));
            this.BtnInsertAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TechnicianPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TechnicianUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TechnicianVerified = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TechnicianServiceID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TechnicianSurname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TechnicianName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TechnicianID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.BtnInsertAdmin.Location = new System.Drawing.Point(183, 304);
            this.BtnInsertAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInsertAdmin.Name = "BtnInsertAdmin";
            this.BtnInsertAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnInsertAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnInsertAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnInsertAdmin.selected = false;
            this.BtnInsertAdmin.Size = new System.Drawing.Size(190, 28);
            this.BtnInsertAdmin.TabIndex = 8;
            this.BtnInsertAdmin.Text = "Insert";
            this.BtnInsertAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInsertAdmin.Textcolor = System.Drawing.Color.White;
            this.BtnInsertAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertAdmin.Click += new System.EventHandler(this.BtnInsertAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TechnicianPassword);
            this.panel1.Controls.Add(this.TechnicianUsername);
            this.panel1.Controls.Add(this.TechnicianVerified);
            this.panel1.Controls.Add(this.TechnicianServiceID);
            this.panel1.Controls.Add(this.TechnicianSurname);
            this.panel1.Controls.Add(this.TechnicianName);
            this.panel1.Controls.Add(this.TechnicianID);
            this.panel1.Location = new System.Drawing.Point(58, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 293);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TechnicianPassword
            // 
            this.TechnicianPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TechnicianPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechnicianPassword.ForeColor = System.Drawing.Color.Black;
            this.TechnicianPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TechnicianPassword.HintText = "";
            this.TechnicianPassword.isPassword = false;
            this.TechnicianPassword.LineFocusedColor = System.Drawing.Color.White;
            this.TechnicianPassword.LineIdleColor = System.Drawing.Color.White;
            this.TechnicianPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TechnicianPassword.LineThickness = 3;
            this.TechnicianPassword.Location = new System.Drawing.Point(6, 256);
            this.TechnicianPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TechnicianPassword.Name = "TechnicianPassword";
            this.TechnicianPassword.Size = new System.Drawing.Size(438, 32);
            this.TechnicianPassword.TabIndex = 6;
            this.TechnicianPassword.Text = "Password";
            this.TechnicianPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TechnicianUsername
            // 
            this.TechnicianUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TechnicianUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechnicianUsername.ForeColor = System.Drawing.Color.Black;
            this.TechnicianUsername.HintForeColor = System.Drawing.Color.Empty;
            this.TechnicianUsername.HintText = "";
            this.TechnicianUsername.isPassword = false;
            this.TechnicianUsername.LineFocusedColor = System.Drawing.Color.White;
            this.TechnicianUsername.LineIdleColor = System.Drawing.Color.White;
            this.TechnicianUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TechnicianUsername.LineThickness = 3;
            this.TechnicianUsername.Location = new System.Drawing.Point(6, 217);
            this.TechnicianUsername.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TechnicianUsername.Name = "TechnicianUsername";
            this.TechnicianUsername.Size = new System.Drawing.Size(438, 32);
            this.TechnicianUsername.TabIndex = 5;
            this.TechnicianUsername.Text = "Username";
            this.TechnicianUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TechnicianVerified
            // 
            this.TechnicianVerified.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TechnicianVerified.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechnicianVerified.ForeColor = System.Drawing.Color.Black;
            this.TechnicianVerified.HintForeColor = System.Drawing.Color.Empty;
            this.TechnicianVerified.HintText = "";
            this.TechnicianVerified.isPassword = false;
            this.TechnicianVerified.LineFocusedColor = System.Drawing.Color.White;
            this.TechnicianVerified.LineIdleColor = System.Drawing.Color.White;
            this.TechnicianVerified.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TechnicianVerified.LineThickness = 3;
            this.TechnicianVerified.Location = new System.Drawing.Point(6, 175);
            this.TechnicianVerified.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TechnicianVerified.Name = "TechnicianVerified";
            this.TechnicianVerified.Size = new System.Drawing.Size(438, 32);
            this.TechnicianVerified.TabIndex = 4;
            this.TechnicianVerified.Text = "Verified";
            this.TechnicianVerified.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TechnicianServiceID
            // 
            this.TechnicianServiceID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TechnicianServiceID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechnicianServiceID.ForeColor = System.Drawing.Color.Black;
            this.TechnicianServiceID.HintForeColor = System.Drawing.Color.Empty;
            this.TechnicianServiceID.HintText = "";
            this.TechnicianServiceID.isPassword = false;
            this.TechnicianServiceID.LineFocusedColor = System.Drawing.Color.White;
            this.TechnicianServiceID.LineIdleColor = System.Drawing.Color.White;
            this.TechnicianServiceID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TechnicianServiceID.LineThickness = 3;
            this.TechnicianServiceID.Location = new System.Drawing.Point(6, 133);
            this.TechnicianServiceID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TechnicianServiceID.Name = "TechnicianServiceID";
            this.TechnicianServiceID.Size = new System.Drawing.Size(438, 32);
            this.TechnicianServiceID.TabIndex = 3;
            this.TechnicianServiceID.Text = "Service ID";
            this.TechnicianServiceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TechnicianSurname
            // 
            this.TechnicianSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TechnicianSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechnicianSurname.ForeColor = System.Drawing.Color.Black;
            this.TechnicianSurname.HintForeColor = System.Drawing.Color.Empty;
            this.TechnicianSurname.HintText = "";
            this.TechnicianSurname.isPassword = false;
            this.TechnicianSurname.LineFocusedColor = System.Drawing.Color.White;
            this.TechnicianSurname.LineIdleColor = System.Drawing.Color.White;
            this.TechnicianSurname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TechnicianSurname.LineThickness = 3;
            this.TechnicianSurname.Location = new System.Drawing.Point(6, 91);
            this.TechnicianSurname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TechnicianSurname.Name = "TechnicianSurname";
            this.TechnicianSurname.Size = new System.Drawing.Size(428, 32);
            this.TechnicianSurname.TabIndex = 2;
            this.TechnicianSurname.Text = "Surname";
            this.TechnicianSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TechnicianName
            // 
            this.TechnicianName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TechnicianName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechnicianName.ForeColor = System.Drawing.Color.Black;
            this.TechnicianName.HintForeColor = System.Drawing.Color.Empty;
            this.TechnicianName.HintText = "";
            this.TechnicianName.isPassword = false;
            this.TechnicianName.LineFocusedColor = System.Drawing.Color.White;
            this.TechnicianName.LineIdleColor = System.Drawing.Color.White;
            this.TechnicianName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TechnicianName.LineThickness = 3;
            this.TechnicianName.Location = new System.Drawing.Point(6, 49);
            this.TechnicianName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TechnicianName.Name = "TechnicianName";
            this.TechnicianName.Size = new System.Drawing.Size(428, 32);
            this.TechnicianName.TabIndex = 1;
            this.TechnicianName.Text = "Name";
            this.TechnicianName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TechnicianID
            // 
            this.TechnicianID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TechnicianID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechnicianID.ForeColor = System.Drawing.Color.Black;
            this.TechnicianID.HintForeColor = System.Drawing.Color.Empty;
            this.TechnicianID.HintText = "";
            this.TechnicianID.isPassword = false;
            this.TechnicianID.LineFocusedColor = System.Drawing.Color.White;
            this.TechnicianID.LineIdleColor = System.Drawing.Color.White;
            this.TechnicianID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TechnicianID.LineThickness = 3;
            this.TechnicianID.Location = new System.Drawing.Point(6, 5);
            this.TechnicianID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TechnicianID.Name = "TechnicianID";
            this.TechnicianID.Size = new System.Drawing.Size(428, 34);
            this.TechnicianID.TabIndex = 0;
            this.TechnicianID.Text = "Technician ID";
            this.TechnicianID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // InsertTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.BtnInsertAdmin);
            this.Controls.Add(this.panel1);
            this.Name = "InsertTechnician";
            this.Size = new System.Drawing.Size(567, 348);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BtnInsertAdmin;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TechnicianUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TechnicianVerified;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TechnicianServiceID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TechnicianSurname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TechnicianName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TechnicianID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TechnicianPassword;
    }
}
