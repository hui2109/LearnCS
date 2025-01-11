using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTestFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = new SizeClass(10, 0);
            Console.WriteLine("length={0},width={1}", size.Length, size.Width);
            Console.ReadKey();
        }
    }

    public class SizeClass
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public SizeClass(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }
    }

    public struct SizeStruct
    {
        public int _length;

        public SizeStruct(int length)
        {
            _length = length;
        }
    }
}
