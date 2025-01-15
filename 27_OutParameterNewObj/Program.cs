using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_OutParameterNewObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = null;  // 因为是out参数，stu始终会被重新赋值，故赋一个空值即可
            bool b = StudentFactory.Create("Tim", 40, out stu);
            if (b == true)
            {
                Console.WriteLine($"Student {stu.Name}, age is {stu.Age}.");
            }
        }
    }

    class StudentFactory
    {
        public static bool Create(string stuName, int stuAge, out Student result)
        {
            result = null;  // 上来就把输出参数result赋值，这也是该语法所必需的
            if (string.IsNullOrEmpty(stuName))
            {
                return false;  // 学生必须要有名字
            }

            if (stuAge < 20 || stuAge > 80)
            {
                return false;  // 学生年龄必须大于20岁且小于80岁
            }

            result = new Student()
            {
                Name = stuName,  // 初始化器必须用逗号分隔
                Age = stuAge
            };
            return true;

        }
    }

    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
