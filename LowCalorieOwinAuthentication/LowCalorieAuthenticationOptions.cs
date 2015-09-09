using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCalorieOwinAuthentication
{
    public class LowCalorieAuthenticationOptions : AuthenticationOptions
    {

        public bool GernerateLocalToken { get; set; }

        public LowCalorieAuthenticationOptions() : base("LowCalorieAuthentication")
        {
            this.AuthenticationMode = AuthenticationMode.Active;
            GernerateLocalToken = false;

        }
    }
}
