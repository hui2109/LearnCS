using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTestFramework
{
    public delegate void MyDelegate(string message);
    class Program
    {
        static void Main()
        {
            // 隐式调用委托
            MyDelegate del = PrintMessage;

            // 隐式调用委托
            del("Hello, implicit delegate call!");
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

