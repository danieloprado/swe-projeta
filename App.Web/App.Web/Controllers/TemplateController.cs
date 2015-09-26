using System.Web.Mvc;

namespace PlanSchool.Web.Controllers
{
    public class TemplateController : Controller
    {
        public ActionResult Index(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return View();
            }

            var result = ViewEngines.Engines.FindView(ControllerContext, url, null);
            if (result.View != null)
            {
                Response.Headers.Add("X-Template", "true");
                return PartialView(url);
            }

            if (Request.IsAjaxRequest())
            {
                return HttpNotFound();
            }

            return View();
        }
    }
}
