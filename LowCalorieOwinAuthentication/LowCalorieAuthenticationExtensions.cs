using Microsoft.Owin.Extensions;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCalorieOwinAuthentication
{
    public static class LowCalorieAuthenticationExtensions
    {

        public static IAppBuilder UseLowCalorieTokenAuthentication(
    this IAppBuilder app,
    LowCalorieAuthenticationOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }

            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            app.Use(typeof(LowCalorieAuthenticationMiddleware), app, options);
            //This line is important :)
            app.UseStageMarker(PipelineStage.Authenticate);

            return app;
        }

        public static IAppBuilder UseLowCalorieAuthenticationServer(
    this IAppBuilder app,
    LowCalorieAuthenticationServerOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }

            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            app.Use(typeof(LowCalorieAuthenticationServerMiddleware), app, options);

            return app;
        }


        public static IAppBuilder UseLowCalorieAuthentication(
          this IAppBuilder app,
          LowCalorieAuthenticationServerOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }

            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            //This is where you would map options if you had any
            app.UseLowCalorieTokenAuthentication(new LowCalorieAuthenticationOptions());
            app.UseLowCalorieAuthenticationServer(options);
            return app;
        }
    }


   
}
