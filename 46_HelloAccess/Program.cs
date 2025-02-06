using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_HelloAccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Timothy");
            Console.WriteLine(car.Owner);
            car.ShowOwner();
        }
    }

    class Vehicle
    {
        public string Owner { get; set; }

        public Vehicle(string owner)
        {
            Owner = owner;
        }
    }

    class Car : Vehicle
    {
        public Car(string owner) : base(owner)  // 子类要想初始化, 必须先初始化父类, 而父类的构造函数需要一个参数, 因此需要先调用父类的构造函数并传参
        {
            // 什么也不做
        }

        public void ShowOwner()
        {
            Console.WriteLine(base.Owner);  // 此Owner属性是继承下来的
        }
    }
}
