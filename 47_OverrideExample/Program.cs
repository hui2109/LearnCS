using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_OverrideExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Car();  // is a: [是一个]语法
            v1.Run1();  // 多态性的表现 polymorphism
            v1.Run2();

            Console.WriteLine("==================================");

            Vehicle v2 = new RaceCar();
            // 重点: 此时v2中有: RaceCar类型的Run2, Car类型的Run2, Car类型的Run1, 和 Vehicle类型的Run1
            v2.Run1();
            v2.Run2();
        }
    }

    class Vehicle
    {
        public void Run1()
        {
            Console.WriteLine("I'm running!   1");
        }

        public virtual void Run2()  // virtual: 名存实亡
        {
            Console.WriteLine("I'm running!   2");
        }

        // 属性也可以被重写
        private int _speed;
        public virtual int Speed { get { return _speed; } set { _speed = value; } }
    }

    class Car : Vehicle
    {
        public new void Run1()  // 隐藏了基类中的成员, 此时Car实例既有基类中的Run1方法, 也有自己的Run1方法
        {
            Console.WriteLine("Car is runing!   1");
        }

        public override void Run2()  // 重写基类中的Run2方法, virtual和override必须同时出现
        {
            Console.WriteLine("Car is runing!   2");
        }

        // 属性也可以被重写
        public override int Speed { get => base.Speed; set => base.Speed = value; }
    }

    class RaceCar : Car
    {
        public new void Run2()  // 这里也用override关键字, 重写Run2方法
        {
            Console.WriteLine("RaceCar is runing!   2");
        }
    }
}
