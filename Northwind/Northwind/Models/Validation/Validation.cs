using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

using System.ComponentModel.DataAnnotations;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

using Northwind.DAL;

namespace Northwind.Models.Validation
{

    public class ApplicationUser : IdentityUser
    {
        public int Year { get; set; }
        public ApplicationUser()
        {
        }
    }

    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store)
                : base(store)
        {
        }
        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options,
                                                IOwinContext context)
        {
            NorthwindModel db = context.Get<NorthwindModel>();
            ApplicationUserManager manager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));
            return manager;
        }
    }
        
    public class Register
    {
        public virtual Employees employee { get; set; }

        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }

    public class Login
    {
        public Login()
        {
            this.Message = null;
        }

        [Key]
        public int ID { get; set; }

        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Message { get; set; }
    }

}