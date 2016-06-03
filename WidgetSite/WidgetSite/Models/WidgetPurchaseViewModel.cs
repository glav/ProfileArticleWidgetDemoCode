using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WidgetSite.Models
{
    public class WidgetPurchaseViewModel
    {
        public WidgetPurchaseViewModel(WidgetComponents.Models.Widget widget, decimal totalCost)
        {
            WidgetToBuy = widget;
            TotalCost = totalCost;
        }

        public WidgetComponents.Models.Widget WidgetToBuy { get; set; }
        public decimal TotalCost { get; set; }
    }
}