namespace SEN381_Project_Call_Center_Group_8.userControls
{
    partial class technicianRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(technicianRequest));
            this.dgvTechnicianRequest = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accepted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.btnAccept = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnComplete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicianRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTechnicianRequest
            // 
            this.dgvTechnicianRequest.AllowUserToAddRows = false;
            this.dgvTechnicianRequest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTechnicianRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTechnicianRequest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dgvTechnicianRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTechnicianRequest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(147)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTechnicianRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTechnicianRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnicianRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.request,
            this.clientType,
            this.clientID,
            this.callEmployeeID,
            this.Completed,
            this.Accepted,
            this.technicianID});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTechnicianRequest.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTechnicianRequest.DoubleBuffered = true;
            this.dgvTechnicianRequest.EnableHeadersVisualStyles = false;
            this.dgvTechnicianRequest.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(147)))), ((int)(((byte)(244)))));
            this.dgvTechnicianRequest.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dgvTechnicianRequest.Location = new System.Drawing.Point(0, 61);
            this.dgvTechnicianRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTechnicianRequest.Name = "dgvTechnicianRequest";
            this.dgvTechnicianRequest.ReadOnly = true;
            this.dgvTechnicianRequest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTechnicianRequest.RowHeadersVisible = false;
            this.dgvTechnicianRequest.RowHeadersWidth = 62;
            this.dgvTechnicianRequest.RowTemplate.Height = 24;
            this.dgvTechnicianRequest.Size = new System.Drawing.Size(799, 429);
            this.dgvTechnicianRequest.TabIndex = 0;
            // 
            // id
            // 
            this.id.FillWeight = 150F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 130;
            // 
            // request
            // 
            this.request.FillWeight = 150F;
            this.request.HeaderText = "Request";
            this.request.MinimumWidth = 6;
            this.request.Name = "request";
            this.request.ReadOnly = true;
            this.request.Width = 125;
            // 
            // clientType
            // 
            this.clientType.FillWeight = 150F;
            this.clientType.HeaderText = "Client Type";
            this.clientType.MinimumWidth = 6;
            this.clientType.Name = "clientType";
            this.clientType.ReadOnly = true;
            this.clientType.Width = 125;
            // 
            // clientID
            // 
            this.clientID.FillWeight = 150F;
            this.clientID.HeaderText = "Client ID";
            this.clientID.MinimumWidth = 6;
            this.clientID.Name = "clientID";
            this.clientID.ReadOnly = true;
            this.clientID.Width = 130;
            // 
            // callEmployeeID
            // 
            this.callEmployeeID.FillWeight = 150F;
            this.callEmployeeID.HeaderText = "Call Employee ID";
            this.callEmployeeID.MinimumWidth = 6;
            this.callEmployeeID.Name = "callEmployeeID";
            this.callEmployeeID.ReadOnly = true;
            this.callEmployeeID.Width = 130;
            // 
            // Completed
            // 
            this.Completed.FillWeight = 150F;
            this.Completed.HeaderText = "Completed";
            this.Completed.MinimumWidth = 6;
            this.Completed.Name = "Completed";
            this.Completed.ReadOnly = true;
            this.Completed.Width = 125;
            // 
            // Accepted
            // 
            this.Accepted.FillWeight = 150F;
            this.Accepted.HeaderText = "Accepted";
            this.Accepted.MinimumWidth = 6;
            this.Accepted.Name = "Accepted";
            this.Accepted.ReadOnly = true;
            this.Accepted.Width = 125;
            // 
            // technicianID
            // 
            this.technicianID.FillWeight = 150F;
            this.technicianID.HeaderText = "Technician ID";
            this.technicianID.MinimumWidth = 6;
            this.technicianID.Name = "technicianID";
            this.technicianID.ReadOnly = true;
            this.technicianID.Width = 130;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.txtSearch.Location = new System.Drawing.Point(4, 7);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(450, 48);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Text = "Enter YOUR ID or REQUEST ID";
            this.txtSearch.Enter += new System.EventHandler(this.TxtUsername_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.TxtUsername_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(461, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 48);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 5;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.ActiveBorderThickness = 3;
            this.btnAccept.ActiveCornerRadius = 20;
            this.btnAccept.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAccept.ActiveForecolor = System.Drawing.Color.White;
            this.btnAccept.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAccept.BackColor = System.Drawing.SystemColors.Control;
            this.btnAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccept.BackgroundImage")));
            this.btnAccept.ButtonText = "Accept";
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAccept.IdleBorderThickness = 1;
            this.btnAccept.IdleCornerRadius = 20;
            this.btnAccept.IdleFillColor = System.Drawing.Color.White;
            this.btnAccept.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.btnAccept.IdleLineColor = System.Drawing.Color.SkyBlue;
            this.btnAccept.Location = new System.Drawing.Point(522, 7);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(128, 50);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.ActiveBorderThickness = 3;
            this.btnComplete.ActiveCornerRadius = 20;
            this.btnComplete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnComplete.ActiveForecolor = System.Drawing.Color.White;
            this.btnComplete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnComplete.BackColor = System.Drawing.SystemColors.Control;
            this.btnComplete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComplete.BackgroundImage")));
            this.btnComplete.ButtonText = "Complete";
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnComplete.IdleBorderThickness = 1;
            this.btnComplete.IdleCornerRadius = 20;
            this.btnComplete.IdleFillColor = System.Drawing.Color.White;
            this.btnComplete.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.btnComplete.IdleLineColor = System.Drawing.Color.SkyBlue;
            this.btnComplete.Location = new System.Drawing.Point(664, 5);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(128, 50);
            this.btnComplete.TabIndex = 7;
            this.btnComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(461, 9);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(51, 48);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // technicianRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvTechnicianRequest);
            this.Name = "technicianRequest";
            this.Size = new System.Drawing.Size(799, 486);
            this.Load += new System.EventHandler(this.TechnicianRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicianRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTechnicianRequest;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox btnSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAccept;
        private Bunifu.Framework.UI.BunifuThinButton2 btnComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn request;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn callEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accepted;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianID;
        private System.Windows.Forms.PictureBox btnRefresh;
    }
}
