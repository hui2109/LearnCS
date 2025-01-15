using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_RefParameterNewObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student outterStu = new Student() { Name = "Tim" };
            Console.WriteLine($"HashCode: {outterStu.GetHashCode()}, Name: {outterStu.Name}");
            Console.WriteLine("-------------------------------");
            IWantSideEffect(ref outterStu);
            Console.WriteLine($"HashCode: {outterStu.GetHashCode()}, Name: {outterStu.Name}");
        }

        static void IWantSideEffect(ref Student stu)
        {
            stu = new Student() { Name = "Tom" };
            Console.WriteLine($"HashCode: {stu.GetHashCode()}, Name: {stu.Name}");
        }
    }

    class Student
    {
        public string Name { get; set; }
    }
}
