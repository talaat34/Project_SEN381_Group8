namespace SEN381_Project_Call_Center_Group_8.PresentationLayer.userControls
{
    partial class InsertAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AdminName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AdminSurname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AdminVerified = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AdminUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AdminPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnInsertAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AdminPassword);
            this.panel1.Controls.Add(this.AdminUsername);
            this.panel1.Controls.Add(this.AdminVerified);
            this.panel1.Controls.Add(this.AdminSurname);
            this.panel1.Controls.Add(this.AdminName);
            this.panel1.Controls.Add(this.AdminID);
            this.panel1.Location = new System.Drawing.Point(64, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 264);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AdminID
            // 
            this.AdminID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminID.ForeColor = System.Drawing.Color.Black;
            this.AdminID.HintForeColor = System.Drawing.Color.Empty;
            this.AdminID.HintText = "";
            this.AdminID.isPassword = false;
            this.AdminID.LineFocusedColor = System.Drawing.Color.White;
            this.AdminID.LineIdleColor = System.Drawing.Color.White;
            this.AdminID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AdminID.LineThickness = 3;
            this.AdminID.Location = new System.Drawing.Point(6, 5);
            this.AdminID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AdminID.Name = "AdminID";
            this.AdminID.Size = new System.Drawing.Size(428, 34);
            this.AdminID.TabIndex = 0;
            this.AdminID.Text = "Admin ID";
            this.AdminID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AdminID.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // AdminName
            // 
            this.AdminName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminName.ForeColor = System.Drawing.Color.Black;
            this.AdminName.HintForeColor = System.Drawing.Color.Empty;
            this.AdminName.HintText = "";
            this.AdminName.isPassword = false;
            this.AdminName.LineFocusedColor = System.Drawing.Color.White;
            this.AdminName.LineIdleColor = System.Drawing.Color.White;
            this.AdminName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AdminName.LineThickness = 3;
            this.AdminName.Location = new System.Drawing.Point(6, 49);
            this.AdminName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(428, 32);
            this.AdminName.TabIndex = 1;
            this.AdminName.Text = "Name";
            this.AdminName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AdminSurname
            // 
            this.AdminSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSurname.ForeColor = System.Drawing.Color.Black;
            this.AdminSurname.HintForeColor = System.Drawing.Color.Empty;
            this.AdminSurname.HintText = "";
            this.AdminSurname.isPassword = false;
            this.AdminSurname.LineFocusedColor = System.Drawing.Color.White;
            this.AdminSurname.LineIdleColor = System.Drawing.Color.White;
            this.AdminSurname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AdminSurname.LineThickness = 3;
            this.AdminSurname.Location = new System.Drawing.Point(6, 91);
            this.AdminSurname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AdminSurname.Name = "AdminSurname";
            this.AdminSurname.Size = new System.Drawing.Size(428, 32);
            this.AdminSurname.TabIndex = 2;
            this.AdminSurname.Text = "Surname";
            this.AdminSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AdminVerified
            // 
            this.AdminVerified.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminVerified.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminVerified.ForeColor = System.Drawing.Color.Black;
            this.AdminVerified.HintForeColor = System.Drawing.Color.Empty;
            this.AdminVerified.HintText = "";
            this.AdminVerified.isPassword = false;
            this.AdminVerified.LineFocusedColor = System.Drawing.Color.White;
            this.AdminVerified.LineIdleColor = System.Drawing.Color.White;
            this.AdminVerified.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AdminVerified.LineThickness = 3;
            this.AdminVerified.Location = new System.Drawing.Point(6, 133);
            this.AdminVerified.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AdminVerified.Name = "AdminVerified";
            this.AdminVerified.Size = new System.Drawing.Size(438, 32);
            this.AdminVerified.TabIndex = 3;
            this.AdminVerified.Text = "Verified";
            this.AdminVerified.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AdminUsername
            // 
            this.AdminUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUsername.ForeColor = System.Drawing.Color.Black;
            this.AdminUsername.HintForeColor = System.Drawing.Color.Empty;
            this.AdminUsername.HintText = "";
            this.AdminUsername.isPassword = false;
            this.AdminUsername.LineFocusedColor = System.Drawing.Color.White;
            this.AdminUsername.LineIdleColor = System.Drawing.Color.White;
            this.AdminUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AdminUsername.LineThickness = 3;
            this.AdminUsername.Location = new System.Drawing.Point(6, 175);
            this.AdminUsername.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AdminUsername.Name = "AdminUsername";
            this.AdminUsername.Size = new System.Drawing.Size(438, 32);
            this.AdminUsername.TabIndex = 4;
            this.AdminUsername.Text = "Username";
            this.AdminUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AdminPassword
            // 
            this.AdminPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPassword.ForeColor = System.Drawing.Color.Black;
            this.AdminPassword.HintForeColor = System.Drawing.Color.Empty;
            this.AdminPassword.HintText = "";
            this.AdminPassword.isPassword = false;
            this.AdminPassword.LineFocusedColor = System.Drawing.Color.White;
            this.AdminPassword.LineIdleColor = System.Drawing.Color.White;
            this.AdminPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AdminPassword.LineThickness = 3;
            this.AdminPassword.Location = new System.Drawing.Point(6, 217);
            this.AdminPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AdminPassword.Name = "AdminPassword";
            this.AdminPassword.Size = new System.Drawing.Size(438, 32);
            this.AdminPassword.TabIndex = 5;
            this.AdminPassword.Text = "Password";
            this.AdminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AdminPassword.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox6_OnValueChanged);
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
            this.BtnInsertAdmin.Location = new System.Drawing.Point(189, 275);
            this.BtnInsertAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInsertAdmin.Name = "BtnInsertAdmin";
            this.BtnInsertAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnInsertAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnInsertAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnInsertAdmin.selected = false;
            this.BtnInsertAdmin.Size = new System.Drawing.Size(190, 28);
            this.BtnInsertAdmin.TabIndex = 6;
            this.BtnInsertAdmin.Text = "Insert";
            this.BtnInsertAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInsertAdmin.Textcolor = System.Drawing.Color.White;
            this.BtnInsertAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertAdmin.Click += new System.EventHandler(this.BtnInsertAdmin_Click);
            // 
            // InsertAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.BtnInsertAdmin);
            this.Controls.Add(this.panel1);
            this.Name = "InsertAdmin";
            this.Size = new System.Drawing.Size(572, 323);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AdminUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AdminVerified;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AdminSurname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AdminName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AdminID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AdminPassword;
        private Bunifu.Framework.UI.BunifuFlatButton BtnInsertAdmin;
    }
}
