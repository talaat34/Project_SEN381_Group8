namespace SEN381_Project_Call_Center_Group_8
{
    partial class callCenterDashboard_MSGs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(callCenterDashboard_MSGs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMessages = new System.Windows.Forms.Panel();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.incoming = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outgoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSendMessage = new System.Windows.Forms.Panel();
            this.pcbSend = new System.Windows.Forms.PictureBox();
            this.txtMessage = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserTable = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.dgvUserProfile = new System.Windows.Forms.DataGridView();
            this.usersFullname = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.pnlSendMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSend)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMessages
            // 
            this.pnlMessages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMessages.Controls.Add(this.dgvMessages);
            this.pnlMessages.Controls.Add(this.pnlSendMessage);
            this.pnlMessages.Location = new System.Drawing.Point(257, 71);
            this.pnlMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(541, 430);
            this.pnlMessages.TabIndex = 0;
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMessages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMessages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dgvMessages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.ColumnHeadersVisible = false;
            this.dgvMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incoming,
            this.outgoing});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMessages.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMessages.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMessages.Location = new System.Drawing.Point(0, 2);
            this.dgvMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.RowHeadersVisible = false;
            this.dgvMessages.RowHeadersWidth = 62;
            this.dgvMessages.RowTemplate.Height = 28;
            this.dgvMessages.Size = new System.Drawing.Size(540, 345);
            this.dgvMessages.TabIndex = 1;
            this.dgvMessages.SelectionChanged += new System.EventHandler(this.DgvMessages_SelectionChanged);
            // 
            // incoming
            // 
            this.incoming.HeaderText = "";
            this.incoming.MinimumWidth = 8;
            this.incoming.Name = "incoming";
            this.incoming.ReadOnly = true;
            this.incoming.Width = 202;
            // 
            // outgoing
            // 
            this.outgoing.HeaderText = "";
            this.outgoing.MinimumWidth = 8;
            this.outgoing.Name = "outgoing";
            this.outgoing.ReadOnly = true;
            this.outgoing.Width = 202;
            // 
            // pnlSendMessage
            // 
            this.pnlSendMessage.Controls.Add(this.pcbSend);
            this.pnlSendMessage.Controls.Add(this.txtMessage);
            this.pnlSendMessage.Controls.Add(this.bunifuSeparator1);
            this.pnlSendMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSendMessage.Location = new System.Drawing.Point(0, 341);
            this.pnlSendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSendMessage.Name = "pnlSendMessage";
            this.pnlSendMessage.Size = new System.Drawing.Size(541, 89);
            this.pnlSendMessage.TabIndex = 0;
            // 
            // pcbSend
            // 
            this.pcbSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.pcbSend.Image = ((System.Drawing.Image)(resources.GetObject("pcbSend.Image")));
            this.pcbSend.Location = new System.Drawing.Point(468, 11);
            this.pcbSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbSend.Name = "pcbSend";
            this.pcbSend.Size = new System.Drawing.Size(73, 78);
            this.pcbSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbSend.TabIndex = 2;
            this.pcbSend.TabStop = false;
            this.pcbSend.Click += new System.EventHandler(this.PcbSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.txtMessage.BorderColorIdle = System.Drawing.Color.DarkTurquoise;
            this.txtMessage.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(86)))), ((int)(((byte)(202)))));
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.BorderThickness = 1;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(133)))), ((int)(((byte)(226)))));
            this.txtMessage.isPassword = false;
            this.txtMessage.Location = new System.Drawing.Point(0, 11);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(469, 78);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(541, 11);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(87)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.lblUserTable);
            this.panel2.Controls.Add(this.lblUserID);
            this.panel2.Controls.Add(this.lblUserFullName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(257, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 71);
            this.panel2.TabIndex = 2;
            // 
            // lblUserTable
            // 
            this.lblUserTable.AutoSize = true;
            this.lblUserTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUserTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(87)))), ((int)(((byte)(204)))));
            this.lblUserTable.Location = new System.Drawing.Point(463, 0);
            this.lblUserTable.Name = "lblUserTable";
            this.lblUserTable.Size = new System.Drawing.Size(78, 17);
            this.lblUserTable.TabIndex = 3;
            this.lblUserTable.Text = "tabel name";
            this.lblUserTable.Visible = false;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserID.Location = new System.Drawing.Point(229, 36);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(95, 32);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "User ID";
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserFullName.Location = new System.Drawing.Point(229, 6);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(125, 32);
            this.lblUserFullName.TabIndex = 1;
            this.lblUserFullName.Text = "Full Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(145)))));
            this.panelUsers.Controls.Add(this.dgvUserProfile);
            this.panelUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUsers.Location = new System.Drawing.Point(0, 0);
            this.panelUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(257, 501);
            this.panelUsers.TabIndex = 3;
            // 
            // dgvUserProfile
            // 
            this.dgvUserProfile.AllowUserToAddRows = false;
            this.dgvUserProfile.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUserProfile.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserProfile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dgvUserProfile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUserProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usersFullname});
            this.dgvUserProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUserProfile.Location = new System.Drawing.Point(0, 71);
            this.dgvUserProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUserProfile.Name = "dgvUserProfile";
            this.dgvUserProfile.ReadOnly = true;
            this.dgvUserProfile.RowHeadersVisible = false;
            this.dgvUserProfile.RowHeadersWidth = 62;
            this.dgvUserProfile.RowTemplate.Height = 28;
            this.dgvUserProfile.Size = new System.Drawing.Size(257, 430);
            this.dgvUserProfile.TabIndex = 0;
            this.dgvUserProfile.SelectionChanged += new System.EventHandler(this.DgvUserProfile_SelectionChanged);
            // 
            // usersFullname
            // 
            this.usersFullname.HeaderText = "";
            this.usersFullname.MinimumWidth = 8;
            this.usersFullname.Name = "usersFullname";
            this.usersFullname.ReadOnly = true;
            this.usersFullname.Width = 190;
            // 
            // callCenterDashboard_MSGs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMessages);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "callCenterDashboard_MSGs";
            this.Size = new System.Drawing.Size(799, 501);
            this.pnlMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.pnlSendMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSend)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMessages;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.DataGridView dgvUserProfile;
        private System.Windows.Forms.DataGridViewButtonColumn usersFullname;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSendMessage;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox pcbSend;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMessage;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.Label lblUserTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn incoming;
        private System.Windows.Forms.DataGridViewTextBoxColumn outgoing;
    }
}
