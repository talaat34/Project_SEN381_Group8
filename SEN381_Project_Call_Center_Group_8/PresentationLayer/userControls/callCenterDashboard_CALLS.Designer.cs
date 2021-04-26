namespace SEN381_Project_Call_Center_Group_8
{
    partial class callCenterDashboard_CALLS
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(callCenterDashboard_CALLS));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvCalls = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIndi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.txtSearhBox = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnReloadData = new System.Windows.Forms.PictureBox();
            this.btnCallClient = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReloadData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCallClient)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgvCalls
            // 
            this.dgvCalls.AllowUserToAddRows = false;
            this.dgvCalls.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCalls.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalls.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dgvCalls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCalls.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(147)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colLength,
            this.colTime,
            this.colStat,
            this.colIndi,
            this.colBusi,
            this.empID,
            this.requestID});
            this.dgvCalls.DoubleBuffered = true;
            this.dgvCalls.EnableHeadersVisualStyles = false;
            this.dgvCalls.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(147)))), ((int)(((byte)(244)))));
            this.dgvCalls.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dgvCalls.Location = new System.Drawing.Point(3, 83);
            this.dgvCalls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCalls.Name = "dgvCalls";
            this.dgvCalls.ReadOnly = true;
            this.dgvCalls.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCalls.RowHeadersVisible = false;
            this.dgvCalls.RowHeadersWidth = 62;
            this.dgvCalls.RowTemplate.Height = 28;
            this.dgvCalls.Size = new System.Drawing.Size(794, 418);
            this.dgvCalls.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.FillWeight = 150F;
            this.colID.HeaderText = "Call ID";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colID.Width = 150;
            // 
            // colLength
            // 
            this.colLength.HeaderText = "Call Length";
            this.colLength.MinimumWidth = 8;
            this.colLength.Name = "colLength";
            this.colLength.ReadOnly = true;
            this.colLength.Width = 150;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Call Time";
            this.colTime.MinimumWidth = 8;
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Width = 150;
            // 
            // colStat
            // 
            this.colStat.HeaderText = "Call Status";
            this.colStat.MinimumWidth = 8;
            this.colStat.Name = "colStat";
            this.colStat.ReadOnly = true;
            this.colStat.Width = 150;
            // 
            // colIndi
            // 
            this.colIndi.HeaderText = "Individual ID";
            this.colIndi.MinimumWidth = 8;
            this.colIndi.Name = "colIndi";
            this.colIndi.ReadOnly = true;
            this.colIndi.Width = 150;
            // 
            // colBusi
            // 
            this.colBusi.HeaderText = "Business ID";
            this.colBusi.MinimumWidth = 8;
            this.colBusi.Name = "colBusi";
            this.colBusi.ReadOnly = true;
            this.colBusi.Width = 150;
            // 
            // empID
            // 
            this.empID.HeaderText = "Employee ID";
            this.empID.MinimumWidth = 6;
            this.empID.Name = "empID";
            this.empID.ReadOnly = true;
            this.empID.Width = 125;
            // 
            // requestID
            // 
            this.requestID.HeaderText = "Request ID";
            this.requestID.MinimumWidth = 6;
            this.requestID.Name = "requestID";
            this.requestID.ReadOnly = true;
            this.requestID.Width = 125;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(489, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 40);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearhBox
            // 
            this.txtSearhBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearhBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtSearhBox.Location = new System.Drawing.Point(24, 25);
            this.txtSearhBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearhBox.Name = "txtSearhBox";
            this.txtSearhBox.Size = new System.Drawing.Size(460, 41);
            this.txtSearhBox.TabIndex = 3;
            this.txtSearhBox.Text = "Enter the call ID...";
            this.txtSearhBox.Enter += new System.EventHandler(this.TxtSearhBox_Enter);
            this.txtSearhBox.Leave += new System.EventHandler(this.TxtSearhBox_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(677, 25);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 40);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReloadData
            // 
            this.btnReloadData.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadData.Image")));
            this.btnReloadData.Location = new System.Drawing.Point(627, 25);
            this.btnReloadData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReloadData.Name = "btnReloadData";
            this.btnReloadData.Size = new System.Drawing.Size(44, 40);
            this.btnReloadData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReloadData.TabIndex = 2;
            this.btnReloadData.TabStop = false;
            this.btnReloadData.Visible = false;
            this.btnReloadData.Click += new System.EventHandler(this.BtnReloadAfterSearch_Click);
            // 
            // btnCallClient
            // 
            this.btnCallClient.Image = ((System.Drawing.Image)(resources.GetObject("btnCallClient.Image")));
            this.btnCallClient.Location = new System.Drawing.Point(734, 26);
            this.btnCallClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCallClient.Name = "btnCallClient";
            this.btnCallClient.Size = new System.Drawing.Size(51, 40);
            this.btnCallClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCallClient.TabIndex = 2;
            this.btnCallClient.TabStop = false;
            this.btnCallClient.Click += new System.EventHandler(this.BtnCallClient_Click);
            // 
            // callCenterDashboard_CALLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.txtSearhBox);
            this.Controls.Add(this.btnCallClient);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReloadData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvCalls);
            this.Location = new System.Drawing.Point(20, 20);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "callCenterDashboard_CALLS";
            this.Size = new System.Drawing.Size(799, 501);
            this.Load += new System.EventHandler(this.CallCenterDashboard_CALLS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReloadData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCallClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCalls;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.TextBox txtSearhBox;
        private System.Windows.Forms.PictureBox btnReloadData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusi;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestID;
        private System.Windows.Forms.PictureBox btnCallClient;
    }
}
