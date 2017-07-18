using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Threading.Tasks;

using Northwind.Models.Validation;
using Microsoft.AspNet.Identity.Owin;

using Northwind.Models.Validation;

namespace Northwind.Controllers
{
    [Authorize]
    public class EditController : Controller
    {



        private ApplicationUserManager_V UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager_V>();
            }
        }


        // GET: Employee     
        public async Task<ActionResult> Orders(string userID)
        {
            OrderView order = new OrderView();
            DbLevel db = new DbLevel();

            var a = User.Identity.Name;
            var result = await UserManager.FindByIdAsync(userID);
            if(result!=null)
            {
                order.orders = db.GetOrders(result);
                order.employee = db.GetEmployee(result);
                order.OrderDetails = db.GetOrderDetail(result);
            }
            return View(order);
        }

        public ActionResult Edit(int pid,int oid,string params_)
        {

            return View();
        }

        public async Task<ActionResult> GetUser()
        {           
            string result_ = @"Annonymous";            
            return View(result_);
        }
        
    }
}