using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_AbstractClassExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new RaceCar();  // 多态的表现: 用一个父类类型的变量 引用 子类类型的变量,  结果是 总是调用该继承链上最新的方法
            vehicle.Run();
            vehicle.Fill();
            vehicle.Stop();
        }
    }

    interface IVehicle
    {
        void Stop();
        void Fill();
        void Run();
    }

    abstract class Vehicle : IVehicle
    {
        public void Fill()
        {
            Console.WriteLine("Pay and fill ...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped!");
        }

        abstract public void Run();  // 抽象类只实现了部分逻辑, 没实现的交给子类去实现
    }

    class Car : Vehicle
    {
        public override void Run()  // override关键字 重写抽象类未实现的方法
        {
            Console.WriteLine("Car is running ...");
        }
    }

    class RaceCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("RaceCar is running ...");
        }
    }
}
