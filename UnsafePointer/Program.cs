using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafePointer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Student stu;
                stu.Score = 59;
                stu.Name = "Xiaoming";
                Student* pStu = &stu;
                pStu->Score = 100;  // 特别地 -> 操作符
                (*pStu).Score = 1000;
                Console.WriteLine(stu.Score);
            }
        }
    }

    struct Student
    {
        public string Name;
        public int Score;
    }
}
