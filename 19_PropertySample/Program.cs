using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_PropertySample
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Student
    {
        // 属性的完整写法，code snippet：propfull
        private int age;  // 后台（back）使用驼峰法命名
        public int Age  // 属性使用Pascal法命名
        {
            get { return age; }
            set { age = value; }
        }

        // 静态属性
        private static int vat;
        public static int Vat
        {
            get { return vat; }
            set { vat = value; }
        }


        // 属性的简明写法，code snippet：prop
        public int MyProperty { get; set; }

        // 使用refactor自动将字段转换为属性
        // Edit -> Refactor -> Encapsulate Field
        private int height;
    }
}
