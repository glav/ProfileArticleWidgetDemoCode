using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidgetComponents.Contracts;
using WidgetComponents.Models;

namespace WidgetComponents.Domain
{
    public class CostCalculationService : ICostCalculationService
    {
        private IDataRepository _repository;
        private ILoggingService _loggingService;
        private ILookupService _securityService;

        public CostCalculationService(IDataRepository repository, ILoggingService loggingService, ILookupService securityService)
        {
            _repository = repository;
            _loggingService = loggingService;
            _securityService = securityService;
        }
        public decimal CalculateCost(Widget widget)
        {
            if (widget == null)
            {
                return 0;
            }
            _loggingService.Log(LogLevel.General, $"Calculating cost for Widget:{widget.Name}");

            var costOfParts = widget.Parts.Sum(p => p.UnitCost);
            var subTotalCost = widget.UnitCost + costOfParts;
            var margin = subTotalCost * (decimal)widget.PercentageMargin;
            var totalCost = subTotalCost + margin;
            return totalCost;
        }
    }
}
