using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCalorieOwinAuthentication
{
    public class LowCalorieAuthenticationServerOptions : AuthenticationOptions
    {
        // Super Simple options.. Extend with what ever you need. 
        public ISecureDataFormat<AuthenticationTicket> AccessTokenFormat { get; set; }

        public PathString TokenEndpointPath { get; set; }

        public bool GernerateLocalToken { get; set; }


        public LowCalorieAuthenticationServerOptions() : base("LowCalorieAuthentication")
        {
            this.AuthenticationMode = AuthenticationMode.Passive;
            TokenEndpointPath = new PathString("/token2");
            GernerateLocalToken = false;
        }
    }
}
