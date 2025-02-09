using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_UnitTestExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PowerSupply powerSupply = new PowerSupply();
            DeskFan deskFan = new DeskFan(powerSupply);
            Console.WriteLine(deskFan.Work());
        }
    }

    public interface IPowerSupply
    {
        int GetPower();
    }

    class PowerSupply : IPowerSupply
    {
        public int GetPower()
        {
            return 110;
        }
    }

    public class DeskFan
    {
        private IPowerSupply powerSupply;
        public DeskFan(IPowerSupply powerSupply)
        {
            this.powerSupply = powerSupply;
        }

        public string Work()
        {
            int power = powerSupply.GetPower();
            if (power <= 0)
            {
                return "Won't work.";
            }
            else if (power < 100)
            {
                return "Slow.";
            }
            else if (power < 200)
            {
                return "Work fine";
            }
            else
            {
                return "Warning!";
            }
        }
    }
}
