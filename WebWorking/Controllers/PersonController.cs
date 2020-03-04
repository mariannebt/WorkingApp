using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebWorking.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person/SignIn
        public ActionResult SignIn()
        {
            return View();
        }

        // GET: Person/SignUp
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult Password()
        {
            return View();
        }
    }
}