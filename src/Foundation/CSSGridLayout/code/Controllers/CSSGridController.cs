using System.Web.Mvc;

namespace Foundation.CSSGridLayout.Controllers
{
    #pragma warning disable S101
    public class CSSGridController : Controller
    #pragma warning restore S101
    {
        public ActionResult Container()
        {
            return View();
        }

        public ActionResult Item()
        {
            return View();
        }
    }
}