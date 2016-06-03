using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidgetComponents.Models;

namespace WidgetComponents.Data
{
    public class ReferenceData
    {
        private List<WidgetPart> _parts = new List<WidgetPart>();

        public List<WidgetPart> Parts
        {
            get { return _parts; }
        }
    }

}
