using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Northwind.Models.Validation;

namespace Northwind.Controllers.Tests
{
    [TestClass()]
    public class ValidationControllerTests
    {
        [TestMethod()]
        public void RegisterTest()
        {
            /*
            Login register_ = new Login() { Email = @"A", Password = @"aa" };
            ValidationController homeController = new ValidationController();
            ActionResult result = homeController.Index(10);
            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
            RedirectToRouteResult routeResult = result as RedirectToRouteResult;
            Assert.AreEqual(routeResult.RouteValues["action"], "asd");
            */
            Assert.Fail();
        }
    }
}