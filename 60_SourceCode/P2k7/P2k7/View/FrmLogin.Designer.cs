namespace P2k7.View
{
    partial class FrmLogin
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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlProjectServerUrl = new System.Windows.Forms.GroupBox();
            this.txtProjectServerUrl = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlProjectServerUrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.BtnCancel);
            this.pnlFooter.Controls.Add(this.BtnLogin);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(5, 80);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(509, 42);
            this.pnlFooter.TabIndex = 1;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody.Controls.Add(this.pnlProjectServerUrl);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(5, 5);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(509, 75);
            this.pnlBody.TabIndex = 0;
            // 
            // pnlProjectServerUrl
            // 
            this.pnlProjectServerUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProjectServerUrl.Controls.Add(this.txtProjectServerUrl);
            this.pnlProjectServerUrl.Location = new System.Drawing.Point(3, 13);
            this.pnlProjectServerUrl.Name = "pnlProjectServerUrl";
            this.pnlProjectServerUrl.Size = new System.Drawing.Size(503, 44);
            this.pnlProjectServerUrl.TabIndex = 4;
            this.pnlProjectServerUrl.TabStop = false;
            this.pnlProjectServerUrl.Text = "ProjectServerUrl";
            // 
            // txtProjectServerUrl
            // 
            this.txtProjectServerUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectServerUrl.Location = new System.Drawing.Point(6, 18);
            this.txtProjectServerUrl.Name = "txtProjectServerUrl";
            this.txtProjectServerUrl.Size = new System.Drawing.Size(491, 19);
            this.txtProjectServerUrl.TabIndex = 0;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.Location = new System.Drawing.Point(316, 8);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(92, 31);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(414, 8);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(92, 31);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "CANCEL";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 127);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Login";
            this.pnlFooter.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlProjectServerUrl.ResumeLayout(false);
            this.pnlProjectServerUrl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.GroupBox pnlProjectServerUrl;
        private System.Windows.Forms.TextBox txtProjectServerUrl;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnLogin;
    }
}

