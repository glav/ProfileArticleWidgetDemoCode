using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetComponents.Models
{
    public class Widget
    {
        private List<WidgetPart> _parts = new List<WidgetPart>();

        public Widget(long id, string name, decimal unitCost, float percentageMargin, IEnumerable<WidgetPart> parts = null)
        {
            if (string.IsNullOrWhiteSpace(name) || unitCost < 0)
            {
                throw new ArgumentException("Invalid parameters specified for widget");
            }
            Id = id;
            Name = name;
            UnitCost = unitCost;
            Parts = parts;
            if (percentageMargin < 0 || percentageMargin > 100)
            {
                throw new ArgumentException("Invalid percentage margin.");
            }
        }

        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal UnitCost { get; private set; }
        public float PercentageMargin { get; private set; }
        public IEnumerable<WidgetPart> Parts { get; private set; }
    }
}
