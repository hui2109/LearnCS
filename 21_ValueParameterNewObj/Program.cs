using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ValueParameterNewObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student() { Name = "Tim" };
            SomeMethod(stu);
            Console.WriteLine($"HashCode: {stu.GetHashCode()}, Name: {stu.Name}");
        }

        static void SomeMethod(Student stu)
        {
            stu = new Student()
            {
                Name = "Tom",  // 成员初始化器，逗号分割，没有分号
                Age = 10
            };
            Console.WriteLine($"HashCode: {stu.GetHashCode()}, Name: {stu.Name}");
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age;
    }
}
