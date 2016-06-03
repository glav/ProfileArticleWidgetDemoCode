using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetComponents.Contracts
{
    public interface IDataRepository
    {
        IEnumerable<Models.Widget> GetAllWidgets();
    }
}
