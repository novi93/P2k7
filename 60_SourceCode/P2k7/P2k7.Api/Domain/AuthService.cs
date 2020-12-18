using Microsoft.IdentityModel.Tokens;
using P2k7.Api.Data;
using P2k7.Entities;
using System;
using System.Collections.Generic;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Configuration;

namespace P2k7.Api.Service
{
    public class AuthService : BaseService
    {

        public AuthService(MySettings mySettings, AuthRepository repo)
        {
            this.repository = repo;
        }

        public AuthRepository repository { get; }

        //public void SaveSettings(MySettings Model)
        //{
        //    mySettings.ProjectServerURL = Model.ProjectServerURL;
        //    mySettings.UserName = Model.UserName;
        //    mySettings.PassWord = Model.PassWord;
        //    mySettings.IsWindowsAuth = Model.IsWindowsAuth;
        //    if (Model.IsWindowsAuth)
        //    {
        //        mySettings.WindowsPort = new Uri(Model.ProjectServerURL).Port;
        //    }
        //    else
        //    {
        //        mySettings.FormsPort = new Uri(Model.ProjectServerURL).Port;
        //    }

        //}
        public LoginEntity Login(LoginEntity model)
        {
            string[] creds = GetCreds(model.UserName, model.PassWord);
            string usr = creds[0];
            string pwod = creds[1];

            try
            {
                return repository.Login(model);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string[] GetCreds(string userName, string Password)
        {
            string[] userNamePassword = new string[2];
            try
            {
                var ed = new EncryptDecrypt();
                userNamePassword[0] = ed.Encrypt(userName);
                userNamePassword[1] = ed.Encrypt(Password);
                return userNamePassword;
            }
            catch (Exception ex)
            {

            }
            return userNamePassword;
        }
        public string GetToken(string userName)
        {
            string key = ConfigurationManager.AppSettings["key"].ToString();
            var issuer = ConfigurationManager.AppSettings["issuer"].ToString();

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var permclaims = new List<Claim>();
            permclaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            permclaims.Add(new Claim("valid", "1"));
            permclaims.Add(new Claim("user", userName));
            //todo
            //permclaims.Add(new Claim("", "Ahmed"));

            var token = new JwtSecurityToken(issuer,
                issuer,
                permclaims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials);

            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }
    }
}
