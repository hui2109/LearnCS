using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace _36_SimpleEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            Boy boy = new Boy();
            Girl girl = new Girl();

            timer.Elapsed += boy.Action;
            timer.Elapsed += girl.Action;  // 一个事件 同时绑定 多个事件处理器

            timer.Start();
            Console.ReadLine();
        }

    }

    class Boy
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump!");
        }
    }

    class Girl
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing!");
        }
    }
}
