using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidgetComponents.Models;

namespace WidgetComponents.Contracts
{
    public interface ICostCalculationService
    {
        decimal CalculateCost(Widget widget);
    }
}
