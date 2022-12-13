using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcsams66.Controllers
{
    public class DARWISHController : Controller
    {
        // GET: DARWISH
        public ActionResult Index()
        {
            AdventureWorks2017Entities dc = new AdventureWorks2017Entities();
            var item = dc.Employees.ToList();  

            return View(item);
        }
    }
}