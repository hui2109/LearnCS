using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConstructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student(123, "Clark");
            Console.WriteLine(stu.ID);
            Console.WriteLine(stu.Name);
            Console.WriteLine("===============================");

            // 同时使用另一种构造器
            Student stu2 = new Student();
            Console.WriteLine(stu2.ID);
            Console.WriteLine(stu2.Name);
        }
    }

    class Student
    {
        public Student(int iniID, string iniName)
        {
            this.ID = iniID;
            this.Name = iniName;
        }

        // 方法的重载
        public Student()
        {
            this.ID = 1;
            this.Name = "Angel";
        }

        public int ID;
        public string Name;
    }
}
