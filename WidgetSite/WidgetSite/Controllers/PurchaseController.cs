using System.Web.Mvc;
using WidgetComponents.Contracts;
using WidgetSite.Models;

namespace WidgetSite.Controllers
{
    public class PurchaseController : Controller
    {
        private ICostCalculationService _costCalcService;
        private ILookupService _lookupService;

        public PurchaseController(ICostCalculationService costCalcService, ILookupService lookupService)
        {
            _costCalcService = costCalcService;
            _lookupService = lookupService;
        }
        public ActionResult Index(long id)
        {
            var widget = _lookupService.GetWidgetById(id);

            var viewModel = new WidgetPurchaseViewModel(widget, _costCalcService.CalculateCost(widget));
            return View(viewModel);
        }
    }
}