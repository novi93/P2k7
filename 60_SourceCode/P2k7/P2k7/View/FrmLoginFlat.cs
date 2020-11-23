using MaterialSkin;
using MaterialSkin.Controls;
using P2k7.Core;
using P2k7.ViewModel;
using System;
using System.Web.Services.Protocols;
using System.Windows.Forms;

namespace P2k7.View
{
    public partial class FrmLoginFlat : MaterialForm
    {
        private LoginVM VM;

        public FrmLoginFlat(LoginVM LoginVM)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                                                        Primary.BlueGrey900,
                                                        Primary.BlueGrey500,
                                                        Accent.LightBlue200,
                                                        TextShade.WHITE);
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
                    this.Close();
                }
            }
            catch (SoapException se)
            {
                MessageBox.Show(se.Message, Application.ProductName);
                VM.mySettings.loginStatus = 1;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
                VM.mySettings.loginStatus = 1;
                this.Close();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
