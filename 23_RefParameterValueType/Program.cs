using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_RefParameterValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 1;
            IWantSideEffect(ref y);
            Console.WriteLine(y);
        }

        static void IWantSideEffect(ref int x)
        {
            x += 100;
        }
    }
}
