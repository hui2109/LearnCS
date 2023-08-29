using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;
using xxx;

namespace _02_初识类与命名空间
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello, world!");
            Form form = new Form();
            form.ShowDialog();
            double result1 = MyCaculator.Add(1.0, 5.0);
            double result2 = Xxx.Daa(1.0, 5.0);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
