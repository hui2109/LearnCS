using AnimalsSDK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _55_AttributesComplicateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine("=====================================");

            string folder = Path.Combine(Environment.CurrentDirectory, "Animals");
            string[] files = Directory.GetFiles(folder);
            List<Type> animalTypes = new List<Type>();
            foreach (string file in files)
            {
                Assembly assembly = Assembly.LoadFrom(file);  // 加载文件中的程序集
                Type[] types = assembly.GetTypes();  // 加载程序集中的所有类型
                foreach (Type t in types)
                {
                    // 以下是未使用SDK的判断方法
                    //if (t.GetMethod("Voice") != null)  // 检测是否实现了Voice方法
                    //{
                    //    animalTypes.Add(t);
                    //}

                    // 以下是使用SDK的判断方法
                    // 条件1: 包含IAnimal接口
                    bool condition1 = t.GetInterfaces().Contains(typeof(IAnimal));
                    // 条件2: 看他有没有被某一个attribute所修饰, 然后再去做决定, 是放弃它还是保留它, 这就是arribute的用处
                    bool condition2 = !t.GetCustomAttributes(false).Contains(typeof(UnfinishedAttribute));

                    if (condition1 && condition2)
                    {
                        animalTypes.Add(t);
                    }
                }

            }

            while (true)  // 永不停止的程序loop
            {
                Console.WriteLine("=====================================\n");
                for (int i = 0; i < animalTypes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {animalTypes[i].Name}");  // 打印出每个类型的名字
                }
                Console.WriteLine("Please choose an animal:");

                int index = int.Parse(Console.ReadLine());
                if (index > animalTypes.Count || index < 1)
                {
                    Console.WriteLine("No such an animal. Please try again!");
                    continue;
                }

                Console.WriteLine("How many times?");
                int times = int.Parse((Console.ReadLine())); // 定义一个动物叫多少次
                Type t = animalTypes[index - 1];  // 拿到一个动物的类型, 具体是什么类型, 我也不知道
                MethodInfo m = t.GetMethod("Voice");  // 拿到该类型中的Voice方法 [反射机制]
                Object o = Activator.CreateInstance(t);  // 造一个t类型的实例

                // 反射的用法
                //m.Invoke(o, new Object[] { times });  // 调用方法m, 并传参, 参数是一个object类型的数组, 其实就是叫多少次

                // SDK的用法
                IAnimal a = o as IAnimal;
                a.Voice(times);
            }
        }
    }
}
