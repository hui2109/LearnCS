using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_StatementExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 标签语句：用一个标签标记一个语句
            //hello: Console.WriteLine("hello world!");
            //    goto hello;

            // if语句
            int score = 100;
            if (score >= 80 && score <= 100)
            {
                Console.WriteLine("A");
            }
            else if (score >= 60)
            {
                Console.WriteLine("B");
            }
            else if (score >= 40)
            {
                Console.WriteLine("C");
            }
            else if (score >= 0)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("Input Error!");
            }

            // switch语句
            // case后的数据类型要能 隐式转换成 switch后的数据类型
            switch (score)
            {
                case (100):
                    Console.WriteLine("A");
                    break;
                default:
                    break;
            }

            // try语句、throw语句
            Caculator c = new Caculator();
            int r = c.Add("null", "1");
            Console.WriteLine(r);
        }
    }

    public class Caculator
    {
        public int Add(string input1, string input2)
        {
            int a = 0;
            int b = 0;
            bool error = false;

            try
            {
                a = int.Parse(input1);
                b = int.Parse(input2);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
                error = true;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                error = true;
            }
            catch (OverflowException ofe)
            {
                //Console.WriteLine(ofe.Message);
                error = true;
                //throw ofe;
                throw;  // 可以不写ofe
            }
            finally
            {
                if (error)
                {
                    Console.WriteLine("The program has error.");
                }
                else
                {
                    Console.WriteLine("Done!");
                }
            }

            int result = a + b;
            return result;
        }
    }
}
