using NinjectConsole;
using System.Reflection;
using System.Reflection.Metadata;

namespace Ninject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            StandardKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            IDataLayer dl=kernel.Get<IDataLayer>();
            BusinessLayer ks=new BusinessLayer(dl);
            string p = ks.getstring();
            Console.WriteLine(p);
        }
    }
}