using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _17_LoopJumpStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program.WhileExample();
            //Program.DoExample();
            //Program.ForExample();
            Program.ForeachExample();
        }

        public static void WhileExample()
        {
            // while循环
            int score = 0;
            int res = 100;
            while (res == 100)
            {
                Console.WriteLine("Please input first number.");
                string a = Console.ReadLine();
                Console.WriteLine("Please input second number.");
                string b = Console.ReadLine();

                int x = int.Parse(a);
                int y = int.Parse(b);
                res = x + y;
                if (res == 100)
                {
                    score++;
                    Console.WriteLine($"Correct! {a} + {b} = {res}.");
                    Console.WriteLine($"Your current score is {score}");
                }
                else
                {
                    Console.WriteLine($"Error! {a} + {b} = {res}.");
                }
            }

            Console.WriteLine($"Your final score is {score}.");
            Console.WriteLine("GAME OVER!");
        }

        public static void DoExample()
        {
            // do循环
            int score = 0;
            int res = 0;
            do
            {
                Console.WriteLine("Please input first number.");
                string a = Console.ReadLine();
                Console.WriteLine("Please input second number.");
                string b = Console.ReadLine();

                int x = int.Parse(a);
                int y = int.Parse(b);
                res = x + y;
                if (res == 100)
                {
                    score++;
                    Console.WriteLine($"Correct! {a} + {b} = {res}.");
                    Console.WriteLine($"Your current score is {score}");
                }
                else
                {
                    Console.WriteLine($"Error! {a} + {b} = {res}.");
                }
            } while (res == 100);

            Console.WriteLine($"Your final score is {score}.");
            Console.WriteLine("GAME OVER!");
        }

        public static void ForExample()
        {
            // for循环，打印99乘法表
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    //Console.Write($"{i}*{j}={i * j}\t");
                    Console.Write($"*");
                }
                Console.WriteLine();
            }
        }

        public static void ForeachExample()
        {
            // foreach语句用于枚举一个集合的元素，并对该集合中的每个元素执行一次相关的嵌入语句
            List<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            foreach (int item in intList)
            {
                Console.WriteLine(item);
            }
        }
    }


}
