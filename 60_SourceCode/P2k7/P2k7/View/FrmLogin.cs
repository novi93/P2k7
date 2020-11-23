using MaterialSkin;
using MaterialSkin.Controls;
using P2k7.Data;
using P2k7.ViewModel;
using System;
using System.Web.Services.Protocols;
using System.Windows.Forms;

namespace P2k7.View
{
    public partial class FrmLogin : Form
    {
        private LoginVM VM;

        public FrmLogin(LoginVM LoginVM)
        {
            InitializeComponent();

            VM = LoginVM;

            BindingModel();
        }

        private void BindingModel()
        {
            txtProjectServerUrl.DataBindings.Add(new Binding("Text", VM.Model, "ProjectServerUrl"));
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                VM.SaveSettings();
                VM.LoginRepo.ClearImpersonation();
                if (VM.LoginRepo.P12Login())
                {
                    VM.mySettings.loginStatus = 0;
                    this.Close();
                }
            }
            catch (SoapException se)
            {
                MessageBox.Show(se.Message, Application.ProductName);
                VM.mySettings.loginStatus = 1;
                this.txtProjectServerUrl.Focus();
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
                VM.mySettings.loginStatus = 1;
                this.txtProjectServerUrl.Focus();
                //this.Close();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            VM.SaveSettings();
            VM.mySettings.loginStatus = 1;
            this.Close();
        }
    } // class
} // namespace
