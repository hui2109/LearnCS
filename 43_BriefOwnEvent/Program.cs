using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _43_BriefOwnEvent
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            //customer.Order += new OrderEventHandler(waiter.Action);  // 显式委托
            customer.Order += waiter.Action;  // 隐式委托

            OrderEventArgs e = new OrderEventArgs()
            {
                Dish = Dishes.Cold_White_Meat,
                Size = Sizes.Middle
            };
            // 事件只能出现在 += 或 -= 操作符的左边，即只能add或remove，不能调用 [.]方法，即不能调用委托的相关方法，除了在Customer类中
            // The event 'Customer.Order' can only appear on the left hand side of += or -= (except when used from within the type 'Customer')
            //customer.Order.Invoke(customer, e);

            // 触发事件
            customer.OnOrder(Dishes.Fish_Mint, Sizes.Small);
            customer.OnOrder(Dishes.Kung_Pao_Chicken, Sizes.Large);  // 5 dollar(s) + 15 dollar(s) = 20 dollar(s)
        }
    }



    // 构建自己的事件类型
    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);  // 声明委托
    public class OrderEventArgs : EventArgs  // 定义事件参数
    {
        public Dishes Dish { get; set; }
        public Sizes Size { get; set; }
    }

    public class Customer
    {
        //private OrderEventHandler orderEventHandler;  // 简略的事件声明中，封装的委托字段是编译器自动声明的，所以我们不能再用自己声明的委托字段
        public double Bill { get; set; }
        public void PayTheBill()
        {
            Console.WriteLine($"You: I will pay {Bill} dollar(s).");
        }

        // 定义简略的事件声明
        public event OrderEventHandler Order;
        //{
        //    add
        //    {
        //        this.orderEventHandler += value;  // 委托类型的实例用于储存事件处理器
        //    }

        //    remove
        //    {
        //        this.orderEventHandler -= value;
        //    }
        //}

        // 定义触发事件的方法  On开头 + protected 访问权限
        public void OnOrder(Dishes dish, Sizes size)  // 为了演示，改为了 public 访问权限
        {
            Console.WriteLine("Walk into the restaurant.");
            Console.WriteLine("Sit down.");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Let me think think...");
                Thread.Sleep(1000);
            }

            if (this.Order != null)  // 如果Order对应的委托字段（编译器自动声明的），有绑定的 [委托实例]
            {
                OrderEventArgs e = new OrderEventArgs()
                {
                    Dish = dish,
                    Size = size
                };

                // 事件只能出现在 += 或 -= 操作符的左边，即只能add或remove，不能调用 [.]方法，即不能调用委托的相关方法，除了在Customer类中
                // The event 'Customer.Order' can only appear on the left hand side of += or -= (except when used from within the type 'Customer')
                this.Order.Invoke(this, e);  // 这里就调用了事件的 [.]方法
            }

            this.PayTheBill();
        }
    }

    public class Waiter
    {
        internal void Action(Customer customer, OrderEventArgs e)
        {
            Console.WriteLine($"Waiter: I will serve you the dish - {e.Dish}, with {e.Size} size.");
            double price = 10.0;
            switch (e.Size)
            {
                case Sizes.Small:
                    price = price * 0.5;
                    break;
                case Sizes.Large:
                    price = price * 1.5;
                    break;
                default:
                    break;
            }

            customer.Bill += price;
        }
    }

    public enum Dishes
    {
        Kung_Pao_Chicken,
        Cold_White_Meat,
        Fish_Mint
    }

    public enum Sizes
    {
        Middle,
        Small,
        Large
    }
}
