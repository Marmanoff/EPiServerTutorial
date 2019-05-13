using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EPiServerTutorial1.Models.Pages;

namespace EPiServerTutorial1.Controllers
{
    public class EpicPageController : PageController<EpicPage>
    {
        public ActionResult Index(EpicPage currentPage)
        {
            return View(currentPage);
        }
    }
}