using Microsoft.Owin;
using Microsoft.Owin.Security.Infrastructure;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCalorieOwinAuthentication
{
    class LowCalorieAuthenticationMiddleware : AuthenticationMiddleware<LowCalorieAuthenticationOptions>
    {

        public LowCalorieAuthenticationMiddleware(OwinMiddleware next, IAppBuilder app, LowCalorieAuthenticationOptions options)
            : base(next, options)
        {
            //setup defaults 
        }

        protected override AuthenticationHandler<LowCalorieAuthenticationOptions> CreateHandler()
        {
            return new LowCalorieAuthenticationHandler();
        }
    }
}
