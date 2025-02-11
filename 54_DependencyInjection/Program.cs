using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace _54_DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection sc = new ServiceCollection();  // 容器即ServiceCollection
            sc.AddScoped(typeof(IWeapon), typeof(Tank));  // 把各种各样的类型和他们对应的接口都放到容器里边去
            sc.AddScoped(typeof(IVehicle), typeof(Car));
            sc.AddScoped<Driver>();
            sc.AddScoped<Tank>();
            ServiceProvider sp = sc.BuildServiceProvider();

            Console.WriteLine("=================华丽的分割线====================");

            Driver driver = sp.GetService<Driver>();  // Driver类的构造器需要一个IVehicle类型的实例, 通过依赖注入, 已经自动帮我们new了一个Car类型的实例
            driver.Drive();

            Tank tank = sp.GetService<Tank>();
            tank.Run();
            tank.Attack();
        }
    }

    interface IVehicle
    {
        void Run();
    }

    interface IWeapon
    {
        void Attack();
    }

    class Driver
    {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Drive()
        {
            _vehicle.Run();
        }
    }

    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car can run!");
        }
    }

    class Tank : IVehicle, IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Ka!Ka!");
        }

        public void Run()
        {
            Console.WriteLine("Tank can run!");
        }
    }
}
