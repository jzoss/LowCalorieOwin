using Microsoft.Owin.Security.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Security;

namespace LowCalorieOwinAuthentication
{
    //This is you passive middleware. Use it to handle the challange or possibly the local token. 
    class LowCalorieAuthenticationServerHandler : AuthenticationHandler<LowCalorieAuthenticationServerOptions>
    {
        //Important this needs to be overriden, but just calls the base. 
        protected override Task<AuthenticationTicket> AuthenticateCoreAsync()
        {
            return Task.FromResult<AuthenticationTicket>(null);
        }

        /// <summary>The apply response challenge async.</summary>
        /// <returns>The <see cref="Task"/>.</returns>
        protected override async Task ApplyResponseChallengeAsync()
        {
            if (this.Response.StatusCode != 401)
            {
                Task.FromResult<object>(null);
                return;
            }

            var challenge = this.Helper.LookupChallenge(
                this.Options.AuthenticationType,
                this.Options.AuthenticationMode);
            if (challenge != null)
            {
                //OK in here you call the rediret to the 3rd party 
                //return a redirect to some endpoint
            }
            Task.FromResult<object>(null);
            return;
        }
    }
}
