using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.Controllers
{
    [Authorize]
    public class EditController : Controller
    {
        // GET: Employee
        public ActionResult Orders()
        {
            return View();
        }
    }
}