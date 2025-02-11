using AnimalsSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLib2
{
    public class Cow : IAnimal  // 实现了IAnimals接口
    {
        // 一个动物类库, 使用于项目55_
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Moo!");
            }
        }
    }
}
