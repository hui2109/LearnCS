using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_TypeVariableAndMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 23;
            long y = 23L;
            float z = 3.0F;
            double m = 23.0D;
            Console.WriteLine(x.GetType().Name);
            Console.WriteLine(y.GetType().Name);
            Console.WriteLine(z.GetType().Name);
            Console.WriteLine(m.GetType().Name);

            Console.WriteLine("=========================");

            Caculator c = new Caculator();
            int res = c.Add(2, 3);
            Console.WriteLine(res);
            Console.WriteLine(c.Today());
            c.PrintSum(45, 55);

            Console.WriteLine("========================");

            Console.WriteLine(c.GetSum(1, 100));
            Console.WriteLine(c.GetSum(100, 1));
            Console.WriteLine(c.GetSum(100, 100));
        }
        class Caculator
        {
            public int Add(int a, int b)
            {
                int result = a + b;
                return result;
            }

            public string Today()
            {
                DateTime day = DateTime.Now.Date;
                return day.ToString();
            }

            public void PrintSum(int a, int b)
            {
                int res = Add(a, b);
                Console.WriteLine(res);
            }

            public int GetSum(int a, int b)
            {
                int res = 0;
                if (a < b)
                {
                    for (int i = a; i <= b; i++)
                    {
                        res += i;
                    }
                    return res;
                }
                else
                {
                    for (int i = b; i <= a; i++)
                    {
                        res += i;
                    }
                    return res;
                }
            }
        }
    }
}
