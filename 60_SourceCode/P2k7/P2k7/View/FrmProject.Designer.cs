namespace P2k7.View
{
    partial class FrmProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProject));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tssOne = new System.Windows.Forms.ToolStripSeparator();
            this.tsProjectDetails = new System.Windows.Forms.ToolStripButton();
            this.tssSix = new System.Windows.Forms.ToolStripSeparator();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.tssEight = new System.Windows.Forms.ToolStripSeparator();
            this.tsExit = new System.Windows.Forms.ToolStripButton();
            this.tssNine = new System.Windows.Forms.ToolStripSeparator();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ssVersion = new System.Windows.Forms.Label();
            this.tsUserName = new System.Windows.Forms.Label();
            this.dgProjList = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.TextBox();
            this.pnlBody.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProjList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.tsMain);
            this.pnlBody.Controls.Add(this.flowLayoutPanel1);
            this.pnlBody.Controls.Add(this.dgProjList);
            this.pnlBody.Controls.Add(this.lblStatus);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1082, 505);
            this.pnlBody.TabIndex = 16;
            // 
            // tsMain
            // 
            this.tsMain.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tsMain.AllowItemReorder = true;
            this.tsMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsMain.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMain.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssOne,
            this.tsProjectDetails,
            this.tssSix,
            this.tsRefresh,
            this.tssEight,
            this.tsExit,
            this.tssNine});
            this.tsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsMain.Location = new System.Drawing.Point(12, 9);
            this.tsMain.Name = "tsMain";
            this.tsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMain.Size = new System.Drawing.Size(241, 25);
            this.tsMain.TabIndex = 16;
            this.tsMain.Text = "Main";
            // 
            // tssOne
            // 
            this.tssOne.Name = "tssOne";
            this.tssOne.Size = new System.Drawing.Size(6, 25);
            // 
            // tsProjectDetails
            // 
            this.tsProjectDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsProjectDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsProjectDetails.Image")));
            this.tsProjectDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsProjectDetails.Name = "tsProjectDetails";
            this.tsProjectDetails.Size = new System.Drawing.Size(127, 22);
            this.tsProjectDetails.Text = "Read Project Details";
            this.tsProjectDetails.Click += new System.EventHandler(this.tsProjectDetails_Click);
            // 
            // tssSix
            // 
            this.tssSix.Name = "tssSix";
            this.tssSix.Size = new System.Drawing.Size(6, 25);
            // 
            // tsRefresh
            // 
            this.tsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsRefresh.Image")));
            this.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRefresh.Name = "tsRefresh";
            this.tsRefresh.Size = new System.Drawing.Size(55, 22);
            this.tsRefresh.Text = "Refresh";
            this.tsRefresh.Click += new System.EventHandler(this.tsRefresh_Click);
            // 
            // tssEight
            // 
            this.tssEight.Name = "tssEight";
            this.tssEight.Size = new System.Drawing.Size(6, 25);
            // 
            // tsExit
            // 
            this.tsExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsExit.Image = ((System.Drawing.Image)(resources.GetObject("tsExit.Image")));
            this.tsExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(32, 22);
            this.tsExit.Text = "Exit";
            // 
            // tssNine
            // 
            this.tssNine.Name = "tssNine";
            this.tssNine.Size = new System.Drawing.Size(6, 25);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ssVersion);
            this.flowLayoutPanel1.Controls.Add(this.tsUserName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 480);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1082, 25);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // ssVersion
            // 
            this.ssVersion.AutoSize = true;
            this.ssVersion.Location = new System.Drawing.Point(3, 0);
            this.ssVersion.Name = "ssVersion";
            this.ssVersion.Size = new System.Drawing.Size(44, 12);
            this.ssVersion.TabIndex = 17;
            this.ssVersion.Text = "Version";
            // 
            // tsUserName
            // 
            this.tsUserName.AutoSize = true;
            this.tsUserName.Location = new System.Drawing.Point(53, 0);
            this.tsUserName.Name = "tsUserName";
            this.tsUserName.Size = new System.Drawing.Size(29, 12);
            this.tsUserName.TabIndex = 18;
            this.tsUserName.Text = "User";
            // 
            // dgProjList
            // 
            this.dgProjList.AllowUserToAddRows = false;
            this.dgProjList.AllowUserToDeleteRows = false;
            this.dgProjList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProjList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgProjList.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgProjList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgProjList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProjList.ColumnHeadersHeight = 20;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProjList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgProjList.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgProjList.GridColor = System.Drawing.Color.Wheat;
            this.dgProjList.Location = new System.Drawing.Point(12, 37);
            this.dgProjList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.dgProjList.Name = "dgProjList";
            this.dgProjList.ReadOnly = true;
            this.dgProjList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgProjList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgProjList.RowHeadersWidth = 42;
            this.dgProjList.RowTemplate.Height = 21;
            this.dgProjList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProjList.ShowEditingIcon = false;
            this.dgProjList.Size = new System.Drawing.Size(1058, 315);
            this.dgProjList.TabIndex = 13;
            this.dgProjList.TabStop = false;
            this.dgProjList.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgProjList_ColumnAdded);
            this.dgProjList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgProjList_MouseClick);
            this.dgProjList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgProjList_MouseDoubleClick);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStatus.Location = new System.Drawing.Point(12, 363);
            this.lblStatus.Multiline = true;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.ReadOnly = true;
            this.lblStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lblStatus.Size = new System.Drawing.Size(1058, 114);
            this.lblStatus.TabIndex = 14;
            // 
            // FrmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 505);
            this.Controls.Add(this.pnlBody);
            this.Name = "FrmProject";
            this.Text = "P2k7";
            this.Load += new System.EventHandler(this.FrmProject_Load);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProjList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TextBox lblStatus;
        public System.Windows.Forms.DataGridView dgProjList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label ssVersion;
        private System.Windows.Forms.Label tsUserName;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripSeparator tssOne;
        private System.Windows.Forms.ToolStripButton tsProjectDetails;
        private System.Windows.Forms.ToolStripSeparator tssSix;
        private System.Windows.Forms.ToolStripButton tsRefresh;
        private System.Windows.Forms.ToolStripSeparator tssEight;
        private System.Windows.Forms.ToolStripButton tsExit;
        private System.Windows.Forms.ToolStripSeparator tssNine;
    }
}

