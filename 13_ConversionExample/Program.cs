using System;

namespace _13_ConversionExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // simple example
            // string tx1 = Console.ReadLine();
            // string tx2 = Console.ReadLine();
            // Console.WriteLine(Convert.ToInt32(tx1) + Convert.ToInt32(tx2));

            // 显式类型转换1 (T)x, 即cast
            Console.WriteLine(ushort.MaxValue);
            uint x = 65536;
            ushort y = (ushort)x;
            Console.WriteLine(y);  // 溢出了
            
            // 显式类型转换2 Convert类
            sbyte z = 126;
            int m = Convert.ToInt32(z);
            Console.WriteLine(m);
            
            // 显式类型转换3 两种ToString方法
            Console.WriteLine(Convert.ToString(z));
            Console.WriteLine(z.ToString());  // 直接调用结构体类型的实例方法
            
            // 显式类型转换4 Parse与tryParse
            string n = "123";
            Console.WriteLine(double.Parse(n));
            
            // 自定义显式类型转换
            Stone stone = new Stone(50000);
            Monkey wuKong = (Monkey)stone;
            Console.WriteLine(wuKong.Age);
        }
    }

    class Stone
    {
        public int Age;

        public Stone(int age)
        {
            this.Age = age;
        }

        public static explicit operator Monkey(Stone stone)
        {
            Monkey m = new Monkey();
            // 石头每5000年, 猴子长1岁
            m.Age = stone.Age / 5000;
            return m;
        }
    }

    class Monkey
    {
        public int Age;
    }
}