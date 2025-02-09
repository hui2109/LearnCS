using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array nums1 = new int[] { 1, 2, 3, 4, 5 };
            ArrayList nums2 = new ArrayList() { 1, 2, 3, 4, 5 };

            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Avg(nums1));

            Console.WriteLine(Sum(nums2));
            Console.WriteLine(Sum(nums2));
        }


        static int Sum(IEnumerable nums)
        {

            int sum = 0;
            foreach (var item in nums)
            {
                sum += (int)item;
            }
            return sum;
        }

        static double Avg(IEnumerable nums)
        {
            int sum = 0;
            double count = 0;
            foreach (var item in nums)
            {
                sum += (int)item;
                count++;
            }
            return sum / count;
        }
    }
}
