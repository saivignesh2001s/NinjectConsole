using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectConsole
{
    public class BusinessLayer
    {
        private readonly IDataLayer _layer;
        public BusinessLayer(IDataLayer layer) {
            _layer = layer;
        }
        public string getstring()
        {
            return _layer.getValue();
        }

    }
}
