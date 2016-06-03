using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidgetComponents.Contracts;
using WidgetComponents.Models;

namespace WidgetComponents.Infrastructure
{
    public class LookupService : ILookupService
    {
        private IDataRepository _repository;

        public LookupService(IDataRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Widget> GetAllWidgets()
        {
            return _repository.GetAllWidgets();
        }

        public Widget GetWidgetById(long id)
        {
            var allWidgets = _repository.GetAllWidgets();
            return allWidgets.FirstOrDefault(w => w.Id == id);
        }
    }
}
