using P2k7.Data;
using P2k7.ViewModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace P2k7.View
{
    public partial class FrmReportActual : Form
    {
        public FrmReportActual(ReportActualVM VM, ProjectRepository loginRepo, FrmLogin frmLogin)
        {
            InitializeComponent();
            this.VM = VM; ;
            this.LoginRepo = loginRepo;
            this.frmLogin = frmLogin;
            this.binding();

            SettingTreeList();

        }

        private void SettingTreeList()
        {
            tlvMain.KeyAspectName = "Id";
            tlvMain.ParentKeyAspectName = "ParentId";
            tlvMain.RootKeyValue = "0";
            tlvMain.CreateColumnFilter();
            tlvMain.UpdateSpaceFillingColumnsWhenDraggingColumnDivider = true;
            tlvMain.GridLines = true;
            tlvMain.IsSearchOnSortColumn = true;
            tlvMain.IncludeColumnHeadersInCopy = true;
            tlvMain.ShowFilterMenuOnRightClick = true;
            tlvMain.ShowKeyColumns = false;
            tlvMain.AutoResizeColumns();
        }

        private void binding()
        {
            ssVersion.DataBindings.Add(new Binding("Text", VM, "ssVersion"));
            tsUserName.DataBindings.Add(new Binding("Text", VM, "tsUserName"));
            datFrom.DataBindings.Add(new Binding("Value", VM.Model, "DateFrom"));
            datTo.DataBindings.Add(new Binding("Value", VM.Model, "DateTo"));
            tlvMain.DataSource = VM.SourcedTree;

        }

        public ReportActualVM VM { get; }
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

                this.Activate();
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

                string version = VM.PrjRepo.ProjectServerVersion();

                if (version.StartsWith("Error"))
                {
                    MessageBox.Show(version, "Admin Web Service Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    VM.ssVersion = "Project Server version: " + version;
                }
                //VM.ReadProjectsList();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                VM.ShowReport();
            //VM.GetData();
            tlvMain.Refresh();
                tlvMain.ExpandAll();
                tlvMain.AutoSizeColumns();
            tlvMain.AutoResizeColumns();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, Application.ProductName);
            }
        }
    } // class
} // namesoace
