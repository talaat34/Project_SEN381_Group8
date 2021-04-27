namespace SEN381_Project_Call_Center_Group_8.PresentationLayer.userControls
{
    partial class InsertEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertEquipment));
            this.BtnInsertAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.equipmentName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.equipmentModelNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.equipmentSerialID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.BtnInsertAdmin.Location = new System.Drawing.Point(175, 261);
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
            this.panel1.Controls.Add(this.equipmentName);
            this.panel1.Controls.Add(this.equipmentModelNumber);
            this.panel1.Controls.Add(this.equipmentSerialID);
            this.panel1.Location = new System.Drawing.Point(46, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 219);
            this.panel1.TabIndex = 7;
            // 
            // equipmentName
            // 
            this.equipmentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.equipmentName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentName.ForeColor = System.Drawing.Color.Black;
            this.equipmentName.HintForeColor = System.Drawing.Color.Empty;
            this.equipmentName.HintText = "";
            this.equipmentName.isPassword = false;
            this.equipmentName.LineFocusedColor = System.Drawing.Color.White;
            this.equipmentName.LineIdleColor = System.Drawing.Color.White;
            this.equipmentName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.equipmentName.LineThickness = 3;
            this.equipmentName.Location = new System.Drawing.Point(6, 91);
            this.equipmentName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.equipmentName.Name = "equipmentName";
            this.equipmentName.Size = new System.Drawing.Size(428, 32);
            this.equipmentName.TabIndex = 2;
            this.equipmentName.Text = "TypeName";
            this.equipmentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // equipmentModelNumber
            // 
            this.equipmentModelNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.equipmentModelNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentModelNumber.ForeColor = System.Drawing.Color.Black;
            this.equipmentModelNumber.HintForeColor = System.Drawing.Color.Empty;
            this.equipmentModelNumber.HintText = "";
            this.equipmentModelNumber.isPassword = false;
            this.equipmentModelNumber.LineFocusedColor = System.Drawing.Color.White;
            this.equipmentModelNumber.LineIdleColor = System.Drawing.Color.White;
            this.equipmentModelNumber.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.equipmentModelNumber.LineThickness = 3;
            this.equipmentModelNumber.Location = new System.Drawing.Point(6, 49);
            this.equipmentModelNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.equipmentModelNumber.Name = "equipmentModelNumber";
            this.equipmentModelNumber.Size = new System.Drawing.Size(428, 32);
            this.equipmentModelNumber.TabIndex = 1;
            this.equipmentModelNumber.Text = "ModelNumber";
            this.equipmentModelNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // equipmentSerialID
            // 
            this.equipmentSerialID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.equipmentSerialID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentSerialID.ForeColor = System.Drawing.Color.Black;
            this.equipmentSerialID.HintForeColor = System.Drawing.Color.Empty;
            this.equipmentSerialID.HintText = "";
            this.equipmentSerialID.isPassword = false;
            this.equipmentSerialID.LineFocusedColor = System.Drawing.Color.White;
            this.equipmentSerialID.LineIdleColor = System.Drawing.Color.White;
            this.equipmentSerialID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.equipmentSerialID.LineThickness = 3;
            this.equipmentSerialID.Location = new System.Drawing.Point(6, 5);
            this.equipmentSerialID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.equipmentSerialID.Name = "equipmentSerialID";
            this.equipmentSerialID.Size = new System.Drawing.Size(428, 34);
            this.equipmentSerialID.TabIndex = 0;
            this.equipmentSerialID.Text = "SerialNumber";
            this.equipmentSerialID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // InsertEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.BtnInsertAdmin);
            this.Controls.Add(this.panel1);
            this.Name = "InsertEquipment";
            this.Size = new System.Drawing.Size(536, 340);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BtnInsertAdmin;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox equipmentName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox equipmentModelNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox equipmentSerialID;
    }
}
