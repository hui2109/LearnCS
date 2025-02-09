using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _50_InterfaceExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NokiaPhone nokiaPhone = new NokiaPhone();
            PhoneUser phoneUser = new PhoneUser(nokiaPhone);
            phoneUser.UsePhone();

            // 手机掉了, 换了个新手机
            EricssonPhone ericssonPhone = new EricssonPhone();
            phoneUser = new PhoneUser(ericssonPhone);
            Console.WriteLine("=====================================");
            phoneUser.UsePhone();
        }
    }

    class PhoneUser
    {
        private IPhone phone;
        public PhoneUser(IPhone phone)  // 用户可以使用不同的手机品牌, 但不同手机品牌具备相同的手机接口
        {
            this.phone = phone;
        }

        public void UsePhone()
        {
            phone.Dail();
            phone.Pickup();
            phone.Send();
            phone.Receive();
        }
    }

    interface IPhone
    {
        void Dail();
        void Pickup();
        void Send();
        void Receive();
    }

    class NokiaPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Nokia calling ...");
        }

        public void Pickup()
        {
            Console.WriteLine("Hi! This is Tim!");
        }

        public void Receive()
        {
            Console.WriteLine("Nokia ring ...");
        }

        public void Send()
        {
            Console.WriteLine("Good evening!");
        }
    }

    class EricssonPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Ericsson calling ...");
        }

        public void Pickup()
        {
            Console.WriteLine("Hi! This is Tim!");
        }

        public void Receive()
        {
            Console.WriteLine("Ericsson ring ...");
        }

        public void Send()
        {
            Console.WriteLine("Good evening!");
        }
    }
}
