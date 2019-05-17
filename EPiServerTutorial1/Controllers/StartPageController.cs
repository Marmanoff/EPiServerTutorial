using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.UI.Report;
using EPiServer.Web.Mvc;
using EPiServerTutorial1.Models.Pages;
using EPiServerTutorial1.Models.ViewModels;


namespace EPiServerTutorial1.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);
            return View(model);
        }
    }
}