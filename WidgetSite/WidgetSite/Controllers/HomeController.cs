using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WidgetComponents.Contracts;
using WidgetSite.Models;

namespace WidgetSite.Controllers
{
    public class HomeController : Controller
    {
        private ILookupService _lookupService;

        public HomeController(ILookupService lookupService)
        {
            _lookupService = lookupService;
        }
        public ActionResult Index()
        {
            var viewModel = new WidgetListViewModel(_lookupService.GetAllWidgets());
            return View(viewModel);
        }

        public ActionResult About()
        {
            return View();
        }

    }
}