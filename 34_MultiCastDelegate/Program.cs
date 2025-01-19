using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _34_MultiCastDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Red };

            //Action act1 = new Action(stu1.DoHomework);  // 显式委托
            Action act1 = stu1.DoHomework;  // 隐式委托
            Action act2 = stu2.DoHomework;
            Action act3 = stu3.DoHomework;

            act1.Invoke();
            act2.Invoke();
            act3.Invoke();

            // multiCast
            Console.WriteLine("--------------------------");
            act1 += act2;
            act1 += act3;
            act1.Invoke();
        }
    }

    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomework()
        {
            Console.ForegroundColor = PenColor;
            Console.WriteLine($"Student {ID} is using {PenColor} color pen.");
        }
    }
}
