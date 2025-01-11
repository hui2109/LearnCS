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
            // new操作符既可以调用类的[构造器]，也可以调用类的[初始化器]
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
            Console.WriteLine(person.GetType().FullName);  // <>f__AnonymousType0`2

            Console.WriteLine("===============================");
            Transport tp = new Transport();
            tp.Fly();
            Car car = new Car();
            car.Fly();
        }

        // new也可以当做修饰符，用于子类重写父类的方法
        class Transport
        {
            public void Fly()
            {
                Console.WriteLine("I can fly.");
            }
        }

        class Car : Transport
        {
            // new修饰符重写Fly方法
            new public void Fly()
            {
                Console.WriteLine("I can not fly.");
            }
        }
    }
}
