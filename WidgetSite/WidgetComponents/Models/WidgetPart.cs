using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetComponents.Models
{
    public class WidgetPart
    {
        public WidgetPart(long id, string name, decimal unitCost, bool isReplaceable = true)
        {
            if (id <= 0 || string.IsNullOrWhiteSpace(name) || unitCost < 0)
            {
                throw new ArgumentException("Invalid parameters specified for widget part");
            }
            Id = id;
            Name = name;
            UnitCost = unitCost;
            IsReplaceable = isReplaceable;
        }
        public long Id { get; private set; }
        public string Name { get; private set; }
        public decimal UnitCost { get; private set; }
        public bool IsReplaceable { get; private set; }

    }
}
