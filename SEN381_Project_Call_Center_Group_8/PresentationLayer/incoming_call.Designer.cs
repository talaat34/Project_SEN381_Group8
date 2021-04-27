namespace SEN381_Project_Call_Center_Group_8.PresentationLayer
{
    partial class incoming_call
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(incoming_call));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCancelCall = new SEN381_Project_Call_Center_Group_8.RoundButton();
            this.btnAnswer = new SEN381_Project_Call_Center_Group_8.RoundButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblUsername);
            this.bunifuGradientPanel1.Controls.Add(this.lblUserID);
            this.bunifuGradientPanel1.Controls.Add(this.btnAnswer);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancelCall);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(72)))), ((int)(((byte)(77)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(8)))), ((int)(((byte)(52)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(198)))), ((int)(((byte)(240)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(94)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(384, 571);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnCancelCall
            // 
            this.btnCancelCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(47)))));
            this.btnCancelCall.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelCall.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelCall.Image")));
            this.btnCancelCall.Location = new System.Drawing.Point(12, 427);
            this.btnCancelCall.Name = "btnCancelCall";
            this.btnCancelCall.Size = new System.Drawing.Size(136, 99);
            this.btnCancelCall.TabIndex = 3;
            this.btnCancelCall.UseVisualStyleBackColor = false;
            this.btnCancelCall.Click += new System.EventHandler(this.BtnCancelCall_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(219)))), ((int)(((byte)(100)))));
            this.btnAnswer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnswer.Image = ((System.Drawing.Image)(resources.GetObject("btnAnswer.Image")));
            this.btnAnswer.Location = new System.Drawing.Point(236, 427);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(136, 99);
            this.btnAnswer.TabIndex = 3;
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblUsername.Location = new System.Drawing.Point(8, 104);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(369, 39);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Call Center";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserID
            // 
            this.lblUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblUserID.Location = new System.Drawing.Point(3, 48);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(374, 39);
            this.lblUserID.TabIndex = 5;
            this.lblUserID.Text = "12134569871236";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incoming_call
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 571);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "incoming_call";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "incoming_call";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private RoundButton btnCancelCall;
        private RoundButton btnAnswer;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserID;
    }
}