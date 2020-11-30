namespace P2k7.View
{
    partial class FrmReportActual
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
            this.components = new System.ComponentModel.Container();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.tlvMain = new BrightIdeasSoftware.DataTreeListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ssVersion = new System.Windows.Forms.Label();
            this.tsUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblRange = new System.Windows.Forms.Label();
            this.datTo = new System.Windows.Forms.DateTimePicker();
            this.datFrom = new System.Windows.Forms.DateTimePicker();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlvMain)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.tlvMain);
            this.pnlBody.Controls.Add(this.flowLayoutPanel1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(933, 512);
            this.pnlBody.TabIndex = 16;
            // 
            // tlvMain
            // 
            this.tlvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlvMain.CellEditUseWholeCell = false;
            this.tlvMain.DataSource = null;
            this.tlvMain.HideSelection = false;
            this.tlvMain.Location = new System.Drawing.Point(12, 45);
            this.tlvMain.Name = "tlvMain";
            this.tlvMain.RootKeyValueString = "";
            this.tlvMain.ShowGroups = false;
            this.tlvMain.Size = new System.Drawing.Size(909, 434);
            this.tlvMain.TabIndex = 16;
            this.tlvMain.UseCompatibleStateImageBehavior = false;
            this.tlvMain.View = System.Windows.Forms.View.Details;
            this.tlvMain.VirtualMode = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ssVersion);
            this.flowLayoutPanel1.Controls.Add(this.tsUserName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 485);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(933, 27);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // ssVersion
            // 
            this.ssVersion.AutoSize = true;
            this.ssVersion.Location = new System.Drawing.Point(3, 0);
            this.ssVersion.Name = "ssVersion";
            this.ssVersion.Size = new System.Drawing.Size(50, 13);
            this.ssVersion.TabIndex = 17;
            this.ssVersion.Text = "Version";
            // 
            // tsUserName
            // 
            this.tsUserName.AutoSize = true;
            this.tsUserName.Location = new System.Drawing.Point(59, 0);
            this.tsUserName.Name = "tsUserName";
            this.tsUserName.Size = new System.Drawing.Size(33, 13);
            this.tsUserName.TabIndex = 18;
            this.tsUserName.Text = "User";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.lblRange);
            this.panel1.Controls.Add(this.datTo);
            this.panel1.Controls.Add(this.datFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 39);
            this.panel1.TabIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(597, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(516, 6);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(251, 11);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(20, 13);
            this.lblRange.TabIndex = 1;
            this.lblRange.Text = "～";
            // 
            // datTo
            // 
            this.datTo.Location = new System.Drawing.Point(277, 9);
            this.datTo.Name = "datTo";
            this.datTo.Size = new System.Drawing.Size(233, 20);
            this.datTo.TabIndex = 1;
            this.datTo.Value = new System.DateTime(2020, 11, 20, 0, 0, 0, 0);
            // 
            // datFrom
            // 
            this.datFrom.Location = new System.Drawing.Point(12, 9);
            this.datFrom.Name = "datFrom";
            this.datFrom.Size = new System.Drawing.Size(233, 20);
            this.datFrom.TabIndex = 0;
            this.datFrom.Value = new System.DateTime(2020, 10, 21, 0, 0, 0, 0);
            // 
            // FrmReportActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(933, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBody);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9.75F);
            this.Name = "FrmReportActual";
            this.Text = "iForn";
            this.Load += new System.EventHandler(this.FrmProject_Load);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlvMain)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label ssVersion;
        private System.Windows.Forms.Label tsUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker datTo;
        private System.Windows.Forms.DateTimePicker datFrom;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnClear;
        private BrightIdeasSoftware.DataTreeListView tlvMain;
    }
}

