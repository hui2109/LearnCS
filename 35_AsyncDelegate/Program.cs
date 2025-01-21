using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _35_AsyncDelegate
{
    internal class Program
    {
        public Student stu1, stu2, stu3;
        public Action act1, act2, act3;

        public Program()
        {
            stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow };
            stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Red };

            act1 = stu1.DoHomework;  // 隐式委托
            act2 = stu2.DoHomework;
            act3 = stu3.DoHomework;
        }

        static void Main(string[] args)
        {
            Program pg = new Program();

            // 同步调用
            //pg.SyncCall();

            // 隐式异步
            //pg.ImplictAsyncCall();

            // 显式异步
            pg.EmplictAsyncCall();


            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Main Thread: {i}");
                Thread.Sleep(1000);
            }
        }

        public void SyncCall()
        {
            Action act4 = act1;
            act4 += act2;
            act4 += act3;
            act4.Invoke();
        }

        public void ImplictAsyncCall()
        {
            act1.BeginInvoke(null, null);
            act2.BeginInvoke(null, null);
            act3.BeginInvoke(null, null);
        }

        public void EmplictAsyncCall()
        {
            Thread th1 = new Thread(new ThreadStart(stu1.DoHomework));
            Thread th2 = new Thread(new ThreadStart(stu2.DoHomework));
            Thread th3 = new Thread(new ThreadStart(stu3.DoHomework));

            th1.Start();
            th2.Start();
            th3.Start();
        }
    }

    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomework()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = PenColor;
                Console.WriteLine($"{i} Student(s) {ID} is using {PenColor} color pen.");
                Thread.Sleep(1000);
            }
        }
    }
}
