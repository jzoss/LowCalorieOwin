using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Infrastructure;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCalorieOwinAuthentication
{
    public class LowCalorieAuthenticationServerMiddleware : AuthenticationMiddleware<LowCalorieAuthenticationServerOptions>
    {

        public LowCalorieAuthenticationServerMiddleware(OwinMiddleware next,IAppBuilder app, LowCalorieAuthenticationServerOptions options)
            : base(next, options)
        {
            //setup defaults 
        }

        protected override AuthenticationHandler<LowCalorieAuthenticationServerOptions> CreateHandler()
        {
            return new LowCalorieAuthenticationServerHandler();
        }
    }
}
