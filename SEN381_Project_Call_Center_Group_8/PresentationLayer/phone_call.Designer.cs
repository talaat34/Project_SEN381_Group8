namespace SEN381_Project_Call_Center_Group_8.PresentationLayer
{
    partial class phone_call
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(phone_call));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMute = new SEN381_Project_Call_Center_Group_8.RoundButton();
            this.btnVolHigh = new SEN381_Project_Call_Center_Group_8.RoundButton();
            this.btnVolLow = new SEN381_Project_Call_Center_Group_8.RoundButton();
            this.lblCalling = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnCancelCal = new SEN381_Project_Call_Center_Group_8.RoundButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(213)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnCancelCal);
            this.bunifuGradientPanel1.Controls.Add(this.btnMute);
            this.bunifuGradientPanel1.Controls.Add(this.btnVolHigh);
            this.bunifuGradientPanel1.Controls.Add(this.btnVolLow);
            this.bunifuGradientPanel1.Controls.Add(this.lblCalling);
            this.bunifuGradientPanel1.Controls.Add(this.lblUsername);
            this.bunifuGradientPanel1.Controls.Add(this.lblPhoneNumber);
            this.bunifuGradientPanel1.Controls.Add(this.lblUserID);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(72)))), ((int)(((byte)(77)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(8)))), ((int)(((byte)(52)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(198)))), ((int)(((byte)(240)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(94)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(384, 571);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(116)))), ((int)(((byte)(87)))));
            this.btnMute.Image = ((System.Drawing.Image)(resources.GetObject("btnMute.Image")));
            this.btnMute.Location = new System.Drawing.Point(297, 315);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(75, 69);
            this.btnMute.TabIndex = 3;
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.RoundButton3_Click);
            // 
            // btnVolHigh
            // 
            this.btnVolHigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(115)))));
            this.btnVolHigh.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnVolHigh.Image = ((System.Drawing.Image)(resources.GetObject("btnVolHigh.Image")));
            this.btnVolHigh.Location = new System.Drawing.Point(155, 315);
            this.btnVolHigh.Name = "btnVolHigh";
            this.btnVolHigh.Size = new System.Drawing.Size(75, 69);
            this.btnVolHigh.TabIndex = 3;
            this.btnVolHigh.UseVisualStyleBackColor = false;
            this.btnVolHigh.Click += new System.EventHandler(this.BtnVolHigh_Click);
            // 
            // btnVolLow
            // 
            this.btnVolLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(146)))));
            this.btnVolLow.Image = ((System.Drawing.Image)(resources.GetObject("btnVolLow.Image")));
            this.btnVolLow.Location = new System.Drawing.Point(12, 315);
            this.btnVolLow.Name = "btnVolLow";
            this.btnVolLow.Size = new System.Drawing.Size(75, 69);
            this.btnVolLow.TabIndex = 3;
            this.btnVolLow.UseVisualStyleBackColor = false;
            this.btnVolLow.Click += new System.EventHandler(this.BtnVolLow_Click);
            // 
            // lblCalling
            // 
            this.lblCalling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalling.BackColor = System.Drawing.Color.Transparent;
            this.lblCalling.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCalling.Location = new System.Drawing.Point(16, 238);
            this.lblCalling.Name = "lblCalling";
            this.lblCalling.Size = new System.Drawing.Size(353, 31);
            this.lblCalling.TabIndex = 1;
            this.lblCalling.Text = "Calling...";
            this.lblCalling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblUsername.Location = new System.Drawing.Point(8, 95);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(369, 39);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Call Center";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 166);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(360, 39);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "0122223333";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserID
            // 
            this.lblUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblUserID.Location = new System.Drawing.Point(12, 39);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(360, 39);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "12134569871236";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelCal
            // 
            this.btnCancelCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.btnCancelCal.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelCal.Image")));
            this.btnCancelCal.Location = new System.Drawing.Point(124, 441);
            this.btnCancelCal.Name = "btnCancelCal";
            this.btnCancelCal.Size = new System.Drawing.Size(136, 99);
            this.btnCancelCal.TabIndex = 3;
            this.btnCancelCal.UseVisualStyleBackColor = false;
            this.btnCancelCal.Click += new System.EventHandler(this.BtnCancelCall_Click);
            // 
            // phone_call
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 571);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "phone_call";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "phone_call";
            this.Load += new System.EventHandler(this.Phone_call_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblCalling;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPhoneNumber;
        private RoundButton btnCancelCall;
        private RoundButton btnMute;
        private RoundButton btnVolHigh;
        private RoundButton btnVolLow;
        private RoundButton btnCancelCal;
    }
}