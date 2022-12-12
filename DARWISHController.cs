using System.Linq;
using System.Web.Mvc;

namespace MVC_SOFTWARE_ARCH.Controllers
{
    public class DARWISHController : Controller
    {
        // GET: DARWISH
        public ActionResult Index()
        {
            AdventureWorks2017Entities dc = new AdventureWorks2017Entities();
            var item = dc.ErrorLogs.ToList();
            return View(item);
        }
    }
}