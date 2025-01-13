using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _18_DataMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> stulist = new List<Student>();
            for (int i = 0; i < 100; i++)
            {
                Student stu = new Student();
                stu.Age = 24;
                stu.Score = i;
                stulist.Add(stu);
                //Console.WriteLine(stu.Abcd);  // 实例无法访问常量
            }

            int totalAge = 0;
            int totalScore = 0;
            foreach (Student stu in stulist)
            {
                totalAge += stu.Age;
                totalScore += stu.Score;
            }

            Student.AverageAge = totalAge / Student.Amount;
            Student.AverageScore = totalScore / Student.Amount;

            Student.ReportAmount();
            Student.ReportAverageAge();
            Student.ReportAverageScore();

            Console.WriteLine($"这是一个常量{Student.Abcd}.");
        }
    }
    class Student
    {
        public int Age = 0;
        public int Score = 0;

        public readonly int ID = 1;  // 只读字段只能在 [初始化] 或 [构造函数] 时赋值！

        public const int Abcd = 5;  // 重点: 常量只能是类成员, 不是实例成员, 即没有实例常量; 实例常量的角色由 [只读字段] 担任

        public static int Amount;
        public static int AverageAge = 0;
        public static int AverageScore = 0;

        // 实例构造函数
        public Student()
        {
            Amount++;
            ID = 3;  // 给只读字段赋值
        }

        // 静态构造函数
        static Student()
        {
            Amount = 0;
            //Abcd = 6;  // 常量没法赋值
        }

        public static void ReportAmount()
        {
            Console.WriteLine(Amount);

        }

        public static void ReportAverageAge()
        {
            Console.WriteLine(AverageAge);
        }

        public static void ReportAverageScore()
        {
            Console.WriteLine(AverageScore);
            //Console.WriteLine(Age);  // 这里不能写Age字段，因为静态方法里不能有实例字段
        }

        public void XXX()
        {
            Console.WriteLine(Age);  // 实例方法里可以直接写实例字段，无需 [this.Age]
            //ID = 3; // 这里不能改 只读字段ID 的值了
            Console.WriteLine(Amount);  // 但实例方法里可以写静态字段
        }
    }
}
