using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_NameParamsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInfo(age: 14, name: "Tim");
        }

        static void PrintInfo(string name = "Tom", int age = 26)  // 可选参数
        {
            Console.WriteLine($"Hello {name}, you are {age}.");
        }
    }
}
