using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay11
{
    class Program
    {
        class Product
        {
            public string Name { set; get; }
            public double price { set; get; }
            public int ID { set; get; }
            public string Origin { set; get; }
        }
        static void Main(string[] args)
        {
            /* List<int> a=new List<int>() { 1,2,4,5,23,2,4,8};
             List<string> b;*/

            /*a.Add(1);
            a.AddRange(new int[] { 3, 4, 5 });
            Console.WriteLine(a.Count);
            Console.WriteLine(a[1]);

            a.Insert(3, 10);
            a.RemoveAt(2);
            a.Remove(3);
            foreach(var n in a)
            {
                Console.WriteLine(n);
            }*/

            /*var n = a.Find((e) =>
            {
                return e % 2 == 0;
            });*/
            //Console.WriteLine(n);
            /*var m = a.FindAll((z) =>
            {
                return z % 2 == 0;
            });
            foreach(var c in m)
            {
                Console.WriteLine(m);
            }*/

            /*List<Product> a = new List<Product>() {
                
                new Product()
                {
                    Name="IP15",price = 3000,Origin ="China",ID=999999
                },
                new Product()
                {
                    Name="IP14",price = 2500,Origin ="China",ID=88888
                },
                new Product()
                {
                    Name="IP13",price = 3500,Origin ="China",ID=77777
                },
                new Product()
                {
                    Name="IP12",price = 1500,Origin ="China",ID=66666
                },
            };
            *//*var p=a.Find(
                    (e) =>
                    {
                        return e.Name =="IP13";
                    }
            );
            if (p != null)
            {
                Console.WriteLine($"{p.Name}-{p.price}");
            }*//*

            foreach(var b in a)
            {
                Console.WriteLine($"{b.Name}-{b.price}-{b.Origin}");
            }

            a.Sort(
                (p1, p2) =>
                {
                    if (p1.price == p2.price) return 0;
                    if (p1.price < p2.price) return 1;
                    return -1;
                }
                );
            Console.WriteLine("---------------");
            foreach (var b in a)
            {
                Console.WriteLine($"{b.Name}-{b.price}-{b.Origin}");
            }*/

            SortedList<string, Product> products = new SortedList<string, Product>();
            products["Sanpham1"] = new Product() { Name = "Ip", price = 1000, Origin = "CHina" };
            products["Sanpham2"] = new Product() { Name = "samsung", price = 12000, Origin = "My" };
            products.Add("Sanpham3", new Product() { Name = "vertu", price = 300000, Origin = "ANh" });

          /*  var p = products["Sanpham2"];
            Console.WriteLine(p.Name);

            var keys = products.Keys;
            var valus = products.Values;

            foreach (var c in keys)
            {
                var o = products[c];
                Console.WriteLine(o.Name);
            }*/
            
            foreach(KeyValuePair<string,Product> item in products)
            {
                var key = item.Key;
                var value = item.Value;
                Console.WriteLine($"{key} - {value.Name}");
             }

            products.Remove("Sanpham1");


        }
    }
}
