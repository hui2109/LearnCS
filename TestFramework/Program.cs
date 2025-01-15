using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTestFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            string cc = "aaa";
            SizeClass sc = new SizeClass();
            string scc = sc.XXX(cc);
            Console.WriteLine(scc);
            Console.WriteLine(cc);
        }
    }

    public class SizeClass
    {
        public string XXX(string a)
        {
            return a + "bb";
        }
    }
}
