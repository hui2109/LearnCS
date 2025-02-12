using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student<ulong> student = new Student<ulong>() { Name = "Timothy" };
            student.ID = 12L;
            Console.WriteLine($"{student.ID}, {student.Name}");
        }
    }

    interface IUnique<T>  // 泛型接口
    {
        T ID { get; set; }  // 接口中的属性
    }

    class Student<T> : IUnique<T>  // 如果一个类它实现的是泛型接口，那么这个类它本身也是泛型的
    {
        public T ID { get; set; }
        public string Name { get; set; }
    }
}
