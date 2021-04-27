namespace SEN381_Project_Call_Center_Group_8.PresentationLayer.userControls
{
    partial class AdminDashboard_INSERT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.insertAdmin1 = new SEN381_Project_Call_Center_Group_8.PresentationLayer.userControls.InsertAdmin();
            this.insertEquipment1 = new SEN381_Project_Call_Center_Group_8.PresentationLayer.userControls.InsertEquipment();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.insertTechnicians1 = new SEN381_Project_Call_Center_Group_8.PresentationLayer.userControls.InsertTechnicians();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSERT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // insertAdmin1
            // 
            this.insertAdmin1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.insertAdmin1.Location = new System.Drawing.Point(16, 127);
            this.insertAdmin1.Name = "insertAdmin1";
            this.insertAdmin1.Size = new System.Drawing.Size(572, 323);
            this.insertAdmin1.TabIndex = 3;
            // 
            // insertEquipment1
            // 
            this.insertEquipment1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.insertEquipment1.Location = new System.Drawing.Point(28, 143);
            this.insertEquipment1.Name = "insertEquipment1";
            this.insertEquipment1.Size = new System.Drawing.Size(572, 323);
            this.insertEquipment1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Technician",
            "Equipment"});
            this.comboBox1.Location = new System.Drawing.Point(268, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // insertTechnicians1
            // 
            this.insertTechnicians1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.insertTechnicians1.Location = new System.Drawing.Point(0, 127);
            this.insertTechnicians1.Name = "insertTechnicians1";
            this.insertTechnicians1.Size = new System.Drawing.Size(635, 338);
            this.insertTechnicians1.TabIndex = 1;
            // 
            // AdminDashboard_INSERT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.insertTechnicians1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.insertEquipment1);
            this.Controls.Add(this.insertAdmin1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard_INSERT";
            this.Size = new System.Drawing.Size(638, 450);
            this.Load += new System.EventHandler(this.AdminDashboard_INSERT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private InsertAdmin insertAdmin1;
        private InsertEquipment insertEquipment1;
        private System.Windows.Forms.ComboBox comboBox1;
        private InsertTechnicians insertTechnicians1;
    }
}
