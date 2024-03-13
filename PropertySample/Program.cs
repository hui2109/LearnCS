using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model1 model = new Model1();
            foreach (var item in model.MSreplication_options)
            {
                Console.WriteLine(model.GetType().Name);
                Console.WriteLine(item.optname);
            }
            Console.WriteLine("==================");
            Console.WriteLine(model.MSreplication_options.Count());
        }
    }
}
