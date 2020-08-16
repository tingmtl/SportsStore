using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Vic.SportsStore.WebApp.Infrastructure.Abstract;

namespace Vic.SportsStore.WebApp.Infrastructure.Contrete
{
    public class FormsAuthProvider : IAuthProvider
    {

        public bool Authenticate(string username, string password)
        {
            bool result = false;
            if(username.Equals("admin", StringComparison.OrdinalIgnoreCase) 
                && password.Equals("adminpsw", StringComparison.OrdinalIgnoreCase))
            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;
        }
    }
}