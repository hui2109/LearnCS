using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_ThisExtension2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 10, 12, 13, 14, 15 };
            bool result = myList.All(i => i > 10);  // 判断List中是否所有的数都大于10
            Console.WriteLine(result);
        }
    }
}
