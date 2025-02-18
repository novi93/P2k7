﻿using P2k7.Data;
using P2k7.Entities;
using P2k7.ViewModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace P2k7.View
{
    public partial class FrmProject : Form
    {
        public FrmProject(ProjectVM projectVM, ProjectRepository loginRepo, FrmLogin frmLogin)
        {
            InitializeComponent();
            this.VM = projectVM; ;
            this.LoginRepo = loginRepo;
            this.frmLogin = frmLogin;
            this.binding();
        }

        private void binding()
        {
            ssVersion.DataBindings.Add(new Binding("Text", VM, "ssVersion"));
            lblStatus.DataBindings.Add(new Binding("Text", VM, "lblStatus"));
            tsUserName.DataBindings.Add(new Binding("Text", VM, "tsUserName"));
            dgProjList.DataSource = VM.SourcedgProjList;
        }

        public ProjectVM VM { get; }
        public ProjectRepository LoginRepo { get; }
        public FrmLogin frmLogin { get; }

        private void FrmProject_Load(object sender, EventArgs e)
        {
            Application.DoEvents();

            try
            {
                this.Cursor = Cursors.WaitCursor;
                ConnectServer();

            }
            catch (Exception ex)
            {
                VM.WriteLog(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;

                //if (Splash.GetSplashForm != null)
                //{
                //    Splash.GetSplashForm.Owner = this;
                //}
                this.Activate();
                //Splash.CloseForm();
            }
        }

        private void ConnectServer()
        {
            if (VM.MySettings.AutoLogin)
            {
                VM.MySettings.ProjectServerURL = VM.MySettings.ProjectServerURL;
                           LoginRepo.P12Login();
            }
            else
            {
             
                this.Activate();

                frmLogin.ShowDialog();
            }
            if (VM.MySettings.loginStatus == 1)
            {
                Application.Exit();
            }
            else
            {
                System.Threading.Thread.Sleep(1000);  // Sleep only here.

                string version = VM.LoginRepo.ProjectServerVersion();

                if (version.StartsWith("Error"))
                {
                    MessageBox.Show(version, "Admin Web Service Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    VM.ssVersion = "Project Server version: " + version;
                }
                VM.ReadProjectsList();
            }
        }

        private void tsRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                VM.ReadProjectsList();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, Application.ProductName);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ShowProjectDetails()
        {
            if (dgProjList.SelectedRows.Count > 0)
            {
                for (int row = 0; row < dgProjList.RowCount; row++)
                {
                    if (dgProjList.Rows[row].Selected == true)
                    {
                        var project = new ProjectInfo();

                        project.projectGuid = new Guid(dgProjList.Rows[row].Cells[0].Value.ToString());

                    }
                }
            }
            else
            {
                VM.WriteLog("No project(s) is selected");
            }
            VM.ReadProjectsList();
        }

        private void tsProjectDetails_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ShowProjectDetails();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, Application.ProductName);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        protected override void OnPaint(PaintEventArgs paintEvnt)
        {
            Pen myPen = new System.Drawing.Pen(Color.Black, 2);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, 0, 30, this.Width, 30);
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void dgProjList_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.ReadOnly == true)
            {
                e.Column.DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                e.Column.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dgProjList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    System.Windows.Forms.DataGridView.HitTestInfo myHitTest;
                    myHitTest = this.dgProjList.HitTest(e.X, e.Y);
                    this.dgProjList.CurrentCell = this.dgProjList.Rows[myHitTest.RowIndex].Cells[myHitTest.ColumnIndex];
                    Clipboard.SetText(dgProjList.CurrentCell.Value.ToString());
                }
                catch
                {

                }
            }
        }

        private void dgProjList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ShowProjectDetails();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, Application.ProductName);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    } // class
} // namesoace
