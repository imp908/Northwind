using Microsoft.Owin;
using Owin;
using Northwind.Models.Validation;
using Northwind.DAL;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;

namespace Northwind
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // настраиваем контекст и менеджер
            app.CreatePerOwinContext<NorthwindModel>(NorthwindModel.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Validation/Login"),
            });
        }
    }
}