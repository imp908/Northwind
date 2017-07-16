using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Threading.Tasks;

using Northwind.Models.Validation;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

using Northwind.DAL;

namespace Northwind.Controllers
{
    public class ValidationController : Controller
    {

        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }

        // GET: Validation
        [AllowAnonymous]
        public ActionResult Login()
        {
            NorthwindModel db = new NorthwindModel();
            int a0 = (from s in db.Employees select s).Count();
            int a = (from s in UserManager.Users select s).Count();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(Login login_)
        {
            if(ModelState.IsValid)
            {
                ApplicationUser user = await UserManager.FindAsync(login_.Email, login_.Password);
                if(user!=null)
                {
                    return  RedirectToAction("Contacts" , "Home", login_);
                }
                else
                {
                    login_.Message = @"Wrong password or username";
                    return RedirectToAction("Register", "Validation", login_);
                }
            }
            return View(login_);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
      
        public async Task<ActionResult> Register(Register login_)
        {
            if (ModelState.IsValid) 
            {
                ApplicationUser user = new ApplicationUser() { UserName = login_.Email  };
                IdentityResult result = await UserManager.CreateAsync(user, login_.Password);

                return RedirectToAction("Login", "Validation");
            }

            return View( );
        }
    }
}