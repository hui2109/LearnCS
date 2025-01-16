using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_ParamsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            int[] intArray = new int[] { 1, 2, 3 };
            //result = CaculateSum(intArray);  // 不需要这样干
            result = CaculateSum(1, 2, 3);  // 直接传参数，自动打包成一个int数组，再将这个int数组传给函数
            Console.WriteLine(result);

            Console.WriteLine("-------------------------------");

            string str = "Tim;Tom,Amy.Lisa";
            string[] res = str.Split(';', '.', ',');  // 调用string自己的Split方法，接受params参数
            foreach (string item in res)
            {
                Console.WriteLine(item);
            }
        }

        static int CaculateSum(params int[] intArray)
        {
            int sum = 0;
            foreach (int item in intArray)
            {
                sum += item;
            }
            return sum;
        }
    }
}
