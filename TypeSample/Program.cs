using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Form);
            PropertyInfo[] pInfos = myType.GetProperties();
            MethodInfo[] mInfos = myType.GetMethods();
            EventInfo[] eInfos = myType.GetEvents();
            foreach (PropertyInfo item in pInfos)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("=================================================");
            foreach (MethodInfo item in mInfos)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (EventInfo item in eInfos)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
