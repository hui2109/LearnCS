using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_TypeInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type mytype = typeof(Form);
            Console.WriteLine(mytype.FullName);
            Console.WriteLine(mytype.BaseType.FullName);
            Console.WriteLine(mytype.IsClass);

            Form form = new Form();
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }
    }
}
