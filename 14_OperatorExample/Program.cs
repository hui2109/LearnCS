using System;

namespace _14_OperatorExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 可空类型
            // 默认情况下, int 不能赋值为空
            // int x = null;

            // 使用Nullable泛型来定义空类型
            Nullable<int> x = null;
            Console.WriteLine(x.HasValue);
            // 更简洁的语法
            int? y = null;
            Console.WriteLine(y.HasValue);

            // Null值合并操作符
            int z = y ?? 1;  // 如果y是null, 就赋值1
            Console.WriteLine(z);

            // 三目运算符
            int m = 80;
            string strT = (m >= 60) ? "Pass" : "Failed";
            Console.WriteLine(strT);
        }
    }
}