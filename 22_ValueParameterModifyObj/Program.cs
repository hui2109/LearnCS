using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_ValueParameterModifyObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student() { Name = "Tim" };
            UpdateObject(stu);
            Console.WriteLine($"HashCode: {stu.GetHashCode()}, Name: {stu.Name}");  // Hash值不变
        }

        static void UpdateObject(Student stu)
        {
            stu.Name = "Tom";  // 副作用 side effect
            Console.WriteLine($"HashCode: {stu.GetHashCode()}, Name: {stu.Name}");
        }
    }

    class Student
    {
        public string Name { get; set; }
    }
}
