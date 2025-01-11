using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_CreateOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 操作符的本质是函数的"简记法"
            int a = 10;
            int b = 4;
            Console.WriteLine(a / b);

            // 操作符不能脱离与他关联的数据类型
            double c = 11;
            double d = 4;
            Console.WriteLine(c / d);

            // typeof操作符，获取Metadata，
            // 包括：类型的名字、属于哪个名称空间、父类是谁、包括多少个属性、方法和事件
            Type e = typeof(int);
            Console.WriteLine(e.FullName);
            Console.WriteLine(e.Name);
            Console.WriteLine(e.Namespace);
            Console.WriteLine(e.GetProperties().Length);
            Console.WriteLine(e.GetMethods().Length);

            // default操作符
            Console.WriteLine("=========================");
            Console.WriteLine(default(int));
            Console.WriteLine(default(string) == null);  // 类的默认值是null
            Console.WriteLine(default(double));
            Console.WriteLine(default(Form) == null);  // 类的默认值是null

            // checked与unchecked操作符及修饰符
            uint x = uint.MaxValue;
            string binStr = Convert.ToString(x, 2);
            Console.WriteLine("=========================");
            Console.WriteLine(x);
            Console.WriteLine(binStr);

            try
            {
                uint y = checked(x + 1);  // checked操作符
                Console.WriteLine(y);  // 位溢出
            }
            catch (OverflowException)
            {
                Console.WriteLine("There's overflow 1!");
            }

            unchecked  // checked修饰符
            {
                try
                {
                    uint y = x + 1;
                    Console.WriteLine(y);  // 位溢出
                }
                catch (OverflowException)
                {
                    Console.WriteLine("There's overflow 2!");
                }
            }

            // sizeof操作符, 默认只能查询[内置]结构体类型在内存中所占的字节
            int m = sizeof(int);
            int n = sizeof(double);
            Console.WriteLine(m);
            Console.WriteLine(n);

            // 在unsafe模式中, 可以查询自定义的结构体类型
            unsafe
            {
                int k = sizeof(Student);
                Console.WriteLine(k);
            }
        }
    }

    struct Student
    {
        int ID;
        long Score;
    }
}

