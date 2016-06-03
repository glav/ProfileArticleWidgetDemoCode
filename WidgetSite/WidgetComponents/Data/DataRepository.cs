using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidgetComponents.Contracts;

namespace WidgetComponents.Data
{
    public class DataRepository : IDataRepository
    {
        private ReferenceData _refData;
        private IEnumerable<Models.Widget> _widgets;
        private int _numberOfPartsToGenerate = 100;
        private int _numberOfWidgetsToGenerate = 10;
        private Random _rnd = new Random(DateTime.Now.Millisecond);


        public DataRepository()
        {
        }

        public IEnumerable<Models.Widget> GetAllWidgets()
        {
            EnsureReferenceDataIsLoaded();

            if (_widgets == null)
            {
                var widgets = new List<Models.Widget>();
                for (var cnt = 0; cnt < _numberOfWidgetsToGenerate;cnt++)
                {
                    var name = $"Widget: {cnt}";
                    var unitCost = _rnd.Next(1, 1000) * (_rnd.Next(1, 10) / _numberOfWidgetsToGenerate) + cnt;
                    float margin = _rnd.Next(1, 20) / 100;
                    widgets.Add(new Models.Widget(cnt + 1, name, unitCost,margin, GetRandomParts()));
                }
                _widgets = widgets;

            }
            return _widgets;
        }

        private void EnsureReferenceDataIsLoaded()
        {
            if (_refData != null)
            {
                // Already loaded reference data
                return;
            }

            LoadReferenceDataIntoMemory();
        }

        private void LoadReferenceDataIntoMemory()
        {
            _refData = new ReferenceData();

            for (var cnt = 0; cnt < _numberOfPartsToGenerate; cnt++)
            {
                // Simulate the time it may take to read the database
                System.Threading.Thread.Sleep(_rnd.Next(100, 200));

                var name = $"Part Number: {cnt}-{_rnd.Next(_numberOfPartsToGenerate, _numberOfPartsToGenerate * 2)}";
                var unitCost = _rnd.Next(1, 1000) * (_rnd.Next(1, 50) / _numberOfPartsToGenerate) + cnt;
                _refData.Parts.Add(new Models.WidgetPart(cnt + 1, name, unitCost, (_rnd.Next(1, 10) > 5)));

            }
        }

        private IEnumerable<Models.WidgetPart> GetRandomParts()
        {
            EnsureReferenceDataIsLoaded();

            var numPartsToMake = _rnd.Next(1, 10);
            var partsList = new List<Models.WidgetPart>();
            for (var cnt=0; cnt < numPartsToMake; cnt++)
            {
                partsList.Add(_refData.Parts[_rnd.Next(0, _numberOfPartsToGenerate - 1)]);
            }
            return partsList;
        }
    }
}
