using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace _02_初识类与命名空间
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello, world!");
            Form form = new Form();
            form.ShowDialog();
            double result1 = BasicCompute.Add(1.0, 5.0);
            double result2 = BasicCompute.Subtract(1.0, 5.0);
            double result3 = BasicCompute.Multiply(1.0, 5.0);
            double result4 = BasicCompute.Divide(1.0, 5.0);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }
    }
}
