using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_AnonymousTypeAndInitializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 显式类型 + 初始化器
            Form MyForm = new Form()
            {
                Text = "Hello",
                WindowState = FormWindowState.Maximized
            };
            MyForm.ShowDialog();

            // 隐式类型 + 初始化器
            var person = new
            {
                Name = "Hui",
                Age = 25
            };
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.GetType().Name);  // <>f__AnonymousType0`2

        }
    }
}
