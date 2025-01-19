using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_TemplateAndCallack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 新建2个委托对象
            Func<Product> func1 = new Func<Product>(ProductFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(ProductFactory.MakeToyCar);

            Box box1 = WrapFactory.WrapProduct(func1, Logger.Log);
            Box box2 = WrapFactory.WrapProduct(func2, Logger.Log);

            Console.WriteLine(box1.MyProduct.Name);
            Console.WriteLine(box2.MyProduct.Name);
        }
    }

    class Box
    {
        public Product MyProduct { get; set; }
    }

    class WrapFactory
    {
        public static Box WrapProduct(Func<Product> getProduct, Action<Product> logCallback)
        // Action 永远没有返回值，<里面的是参数的类型>
        {
            Box box = new Box();
            Product product = getProduct.Invoke();

            // callback逻辑
            if (product.Price >= 50)
            {
                logCallback(product);
            }

            box.MyProduct = product;
            return box;
        }
    }

    class ProductFactory
    {
        public static Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 12;
            return product;
        }

        public static Product MakeToyCar()
        {
            Product product = new Product();
            product.Name = "Toy Car";
            product.Price = 100;
            return product;
        }
    }

    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    class Logger
    {
        public static void Log(Product product)
        {
            Console.WriteLine($"Product {product.Name} created at UTC {DateTime.UtcNow}. Price is {product.Price}.");
        }
    }
}
