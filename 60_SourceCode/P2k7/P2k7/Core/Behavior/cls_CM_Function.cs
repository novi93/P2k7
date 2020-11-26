using Microsoft.VisualBasic.CompilerServices;
using P2k7.LoginwindowsWebSvc;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace P2k7.Core.Behavior
{
    class cls_CM_Function
    {
        // Token: 0x060006B1 RID: 1713 RVA: 0x00027964 File Offset: 0x00025B64
        public static ICredentials GetCredentials(bool allData = false)
        {
            cls_CM_Function.OverrideCertificateValidation();
            ICredentials result;
            if (allData)
            {
                result = new NetworkCredential("qatest", "BbCc2014", "FUJINET");
            }
            else
            {
                bool flag = Operators.CompareString(mod_WMS_Declare.gvObj_LoginInfo.StaffInfo.Password.Trim(), "", false) == 0;
                if (flag)
                {
                    new LoginWindows
                    {
                        Url = "https://projectsvr-01.fujinet.vn/PWA/_vti_bin/PSI/LoginWindows.asmx",
                        Credentials = CredentialCache.DefaultCredentials,
                        UseDefaultCredentials = true
                    }.Login();
                    result = CredentialCache.DefaultCredentials;
                }
                else
                {
                    result = new NetworkCredential(mod_WMS_Declare.gvObj_LoginInfo.StaffInfo.UserName, mod_WMS_Declare.gvObj_LoginInfo.StaffInfo.Password, "FUJINET");
                }
            }
            return result;
        }
        // Token: 0x060006AC RID: 1708 RVA: 0x00026195 File Offset: 0x00024395
        public static void OverrideCertificateValidation()
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(cls_CM_Function.RemoteCertValidate);
        }
        private static bool RemoteCertValidate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            return true;
        }
        // Token: 0x0400043E RID: 1086
        public static string[] TaskPhaseShortName = new string[]
        {
            "REQ",
            "BD",
            "REV_BD",
            "DD",
            "REV_DD",
            "PG",
            "REV_PG",
            "TST1",
            "TST2",
            "TST2_CT",
            "TST2_ST",
            "DEL_TST",
            "FIX_INT",
            "FIX_CUS",
            "MAN",
            "TRN",
            "OTH",
            "NAME",
            "SUB_PRJ",
            "CHN_REQ",
            "RESEARCH",
            "DEDUCTED_EFFORT",
            "SUPPORT1",
            "SUPPORT2",
            "TST1_CRT",
            "TST1_REV",
            "TST2CT_CRT",
            "TST2CT_REV",
            "TST2ST_CRT",
            "TST2ST_REV",
            "JCSUPPORT",
            "SCCONV",
            "QUOTATION",
            "INVESTIGATE1",
            "INVESTIGATE2"
        };
    } // class
} // namespace
