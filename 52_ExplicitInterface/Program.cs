using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_ExplicitInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WarmKiller warmKiller = new WarmKiller();
            warmKiller.Love();  // 打 .只能显示Love方法
            IKiller killer = warmKiller;  // 隐藏的Kill方法
            killer.Kill();
        }
    }

    interface IGentleman
    {
        void Love();
    }

    interface IKiller
    {
        void Kill();
    }

    class WarmKiller : IGentleman, IKiller
    {
        public void Love()
        {
            Console.WriteLine("I love you forever.");
        }

        void IKiller.Kill()  // 接口的显式实现, C#特有的内容
        {
            Console.WriteLine("Let me kill the enemy ...");
        }
    }
}
