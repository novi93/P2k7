namespace P2k7.View
{
    partial class FrmLoginFlat
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProjectServerUrl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.BtnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody.Controls.Add(this.panel1);
            this.pnlBody.Location = new System.Drawing.Point(5, 72);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(509, 77);
            this.pnlBody.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtProjectServerUrl);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 40);
            this.panel1.TabIndex = 1;
            // 
            // txtProjectServerUrl
            // 
            this.txtProjectServerUrl.Depth = 0;
            this.txtProjectServerUrl.Hint = "Project Server name";
            this.txtProjectServerUrl.Location = new System.Drawing.Point(3, 9);
            this.txtProjectServerUrl.MaxLength = 32767;
            this.txtProjectServerUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProjectServerUrl.Name = "txtProjectServerUrl";
            this.txtProjectServerUrl.PasswordChar = '\0';
            this.txtProjectServerUrl.SelectedText = "";
            this.txtProjectServerUrl.SelectionLength = 0;
            this.txtProjectServerUrl.SelectionStart = 0;
            this.txtProjectServerUrl.Size = new System.Drawing.Size(497, 23);
            this.txtProjectServerUrl.TabIndex = 1;
            this.txtProjectServerUrl.TabStop = false;
            this.txtProjectServerUrl.UseSystemPasswordChar = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.BtnCancel);
            this.pnlFooter.Controls.Add(this.BtnLogin);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(5, 155);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(509, 48);
            this.pnlFooter.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLogin.Depth = 0;
            this.BtnLogin.Icon = null;
            this.BtnLogin.Location = new System.Drawing.Point(354, 3);
            this.BtnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Primary = true;
            this.BtnLogin.Size = new System.Drawing.Size(61, 36);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Icon = null;
            this.BtnCancel.Location = new System.Drawing.Point(430, 3);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = false;
            this.BtnCancel.Size = new System.Drawing.Size(73, 36);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel ";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 208);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Login";
            this.pnlBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProjectServerUrl;
        private MaterialSkin.Controls.MaterialRaisedButton BtnLogin;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCancel;
    }
}

