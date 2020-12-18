using P2k7.Entities;
using P2k7.Api.Utils;
using System;
using System.Data;

using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Collections.Generic;
using System.Configuration;
using System.Net;

namespace P2k7.Api.Data
{
    public class AuthRepository
    {
        public PsiWrapper PsiWraper { get; }

        public AuthRepository(PsiWrapper psiWraper)
        {
            PsiWraper = psiWraper;
        }

        public LoginEntity Login(LoginEntity loginEntity)
        {
            CookieContainer cookies = new CookieContainer();
            var baseUrl = loginEntity.ProjectServerURL;
            var addUrl = "/_vti_bin/psi/";

            if (loginEntity.isImpersonated)
            {
                baseUrl = PsiWraper.SetPortforImpersonation(baseUrl, loginEntity.ImpersonationPort);
                addUrl = loginEntity.ImpersonationSite + "/PSI/";
            }
            else
            {
                if (loginEntity.IsWindowsAuth == true)
                {
                    PsiWraper.SetDefaultCredentials();
                }
                else
                {
                    PsiWraper.loginForms.Url = (PsiWraper.SetPortforForms(baseUrl, loginEntity.FormsPort) + "/_vti_bin/psi/LoginForms.asmx");
                    PsiWraper.loginForms.CookieContainer = cookies;
                    if (!PsiWraper.loginForms.Login(loginEntity.UserName, loginEntity.PassWord))
                        return null;
                    PsiWraper.SetCookies(cookies);
                }
            }
            PsiWraper.SetUrl(baseUrl, addUrl);
            return loginEntity;
        }
    }
}
