using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectConsole
{
    public class DataLayer : IDataLayer
    {
        public string getValue()
        {
            return "I am sample on Ninject";
        }
    }
}
