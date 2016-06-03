using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WidgetSite.Models
{
    public class WidgetListViewModel
    {
        public WidgetListViewModel()
        {
            Widgets = new List<WidgetComponents.Models.Widget>();
        }

        public WidgetListViewModel(IEnumerable<WidgetComponents.Models.Widget> widgets)
        {
            Widgets = new List<WidgetComponents.Models.Widget>(widgets);
        }
        public List<WidgetComponents.Models.Widget> Widgets { get; set; }
    }
}