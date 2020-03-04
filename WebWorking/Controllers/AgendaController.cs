using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebWorking.Controllers
{
    public class AgendaController : Controller
    {
        // GET: Agenda
        public ActionResult Calendar()
        {
            return View();
        }
    }
}