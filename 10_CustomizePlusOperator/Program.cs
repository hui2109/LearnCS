using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CustomizePlusOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Daddy");
            Person p2 = new Person("Mommy");
            List<Person> nation = p1 + p2;
            foreach (Person item in nation)
            {
                Console.WriteLine(item.Name);
            }

        }

        class Person
        {
            public string Name;
            public Person(string Name)
            {
                this.Name = Name;
            }
            public static List<Person> operator +(Person p1, Person p2)  // 定义该类的+号操作符
            {
                List<Person> nation = new List<Person>();
                nation.Add(p1);
                nation.Add(p2);

                for (int i = 0; i < 11; i++)
                {
                    Person p = new Person(p1.Name + " and " + p2.Name + $"'s {i + 1}th child");
                    nation.Add(p);
                }

                return nation;
            }
        }
    }
}
