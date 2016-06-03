using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetComponents.Contracts
{
    public interface ILookupService
    {
        Models.Widget GetWidgetById(long id);
        IEnumerable<Models.Widget> GetAllWidgets();
    }
}
