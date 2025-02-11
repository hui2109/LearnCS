using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsSDK;

namespace AnimalsLib1
{
    public class Cat : IAnimal  // 实现了IAnimals接口
    {
        // 一个动物类库, 使用于项目55_
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Miaow!");
            }
        }
    }
}
