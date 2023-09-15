using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay12
{
    public class Product
    {
       

        public int ID { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public string[] Color { set; get; }
        public int Brand { set; get; }
        public Product(int id,string name, double price,string [] color, int brand)
        {
            ID = id;Name = name;Price = price;Color = color;Brand = brand;
        }

       

        public override string ToString()
            => $"{ID,3}-{Name,12}-{Price,5}-{Brand,2}-{string.Join(",", Color)}";
        
    }
    public class Barnd
    {
        public string Name { set; get; }
        public int ID { set; get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var brands = new List<Barnd>()
            {
                new Barnd{ID = 1, Name ="cty AAA"},
                new Barnd{ID = 2, Name ="cty BBB"},
                new Barnd{ID = 4, Name ="cty CCC"}
            };
            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };

            //Lay ra san pham gia 400
            /*var query = from p in products where p.Price == 400 select p;
            foreach(var a in query)
            {
                Console.WriteLine(a);
            }*/


            //select
            /*var kq = products.Select(
                (p) =>
                {
                    return new
                    {
                        Ten = p.Name,
                        Gia = p.Price
                    };
                }
            );
            foreach(var item in kq)
            {
                Console.WriteLine(item);
            }*/

            //Where
            /*var kq = products.Where(
                (p) =>
                {
                    return p.Brand==2;
                }
            );
            foreach (var item in kq)
            {
                Console.WriteLine(item);
            }*/

            //SelectMany
            /*var kq = products.SelectMany(
                (p) =>
                {
                    return p.Color;
                }
            );
            foreach (var item in kq)
            {
                Console.WriteLine(item);
            }*/

            //Min,max,sum,average
            //Console.WriteLine(products.Min(p => p.Price));

            //Join, GroupJoin
            /*var kq = products.Join(brands, p => p.Brand, b => b.ID,(p,b)=> {
                return new
                {
                    Ten = p.Name,
                    Thuonghieu = b.Name,
                };
            });
            foreach(var a in kq)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("-----------------");

            var kq1 = brands.GroupJoin(products, b => b.ID, p => p.Brand, (brand, pros) =>
            {
                return new
                {
                    thuonghieu = brand.Name,
                    Cacsanpham = pros,
                };
            });


            foreach (var item in kq1)
            {
                Console.WriteLine(item.thuonghieu);
                foreach (var p in item.Cacsanpham )
                {
                    Console.WriteLine(p);
                }
            }*/

            //Take,Skip
            /* products.Take(4).ToList().ForEach(p => Console.WriteLine(p));
             Console.WriteLine("---------------");
             products.Skip(2).ToList().ForEach(p => Console.WriteLine(p));*/

            //OrderBy(tang dan) / OrderByDescending (giam gia ) / Reverse (dao nguoc)

            /* products.OrderBy(p => p.Price).ToList().ForEach(p => Console.WriteLine(p));
             Console.WriteLine("---------------");
             products.OrderByDescending(p => p.Price).ToList().ForEach(p => Console.WriteLine(p));
             Console.WriteLine("---------------");
             int[] numbers = { 1, 23, 4, 5, 2, 4, 5 };
             numbers.Reverse().ToList().ForEach(n => Console.WriteLine(n));*/

            //GroupBy
            /*var kq = products.GroupBy(p => p.Brand);
            foreach (var item in kq)
            {
                Console.WriteLine(item.Key);
                foreach (var a in item)
                {
                    Console.WriteLine(a);
                }
            }*/

            //Distinct, Single SingleOfDefault,Any,Cout, 
            /*products.SelectMany(p => p.Color).Distinct().ToList().ForEach(mau => Console.WriteLine(mau));
            var p = products.Single(a => a.Price == 400);
            Console.WriteLine(p);*/





            //VD: In ra ten san pham, thuong hieu co gia 300-400 va kqua in ra gia giam dan
            /*products.Where(p => p.Price >= 300 && p.Price <= 400)
                .OrderByDescending(p => p.Price)
                .Join(brands, p => p.Brand, b => b.ID, (sp, th) =>
                {
                    return new
                    {
                        TenSP = sp.Name,
                        TenTH = th.Name,
                        Gia = sp.Price
                    };
                })
                .ToList()
                .ForEach(info =>
                {
                    Console.WriteLine($"{info.TenSP,15} -{info.TenTH,15}-{info.Gia,10}");
                });*/

            int[] numbers = { 1, 2, 3, 4, 5 };

            /*var qr = from p in products
                     select new
                     {
                         Ten = p.Name,
                         Gia = p.Price,
                     };
            qr.ToList().ForEach(name => Console.WriteLine(name));*/
            /*var qr = from p in products
                     from color in p.Color
            
                     where p.Price <=400 && color=="Xanh"
                     orderby p.Price  

                     select new
                     {
                         Ten = p.Name,
                         Gia = p.Price,
                         Mau = p.Color,
                     };
            qr.ToList().ForEach(a =>
            {
                Console.WriteLine($"{a.Ten} -{a.Gia} -{string.Join(",", a.Mau)}");
                
            }
            );*/

            /*var qr = from p in products
                     group p by p.Price into gr
                     orderby gr.Key
                     let sl=gr.Count()
                     select new
                     {
                         Gia = gr.Key,
                        cacsp = gr.ToList(),
                        soluong = sl,

                     };
                    

            qr.ToList().ForEach(gro =>
            {
                Console.WriteLine(gro.Gia);
                Console.WriteLine(gro.soluong);
                gro.cacsp.ForEach(a => Console.WriteLine(a));
            });*/

            var qr = from p in products
                     join brand in brands on p.Brand equals brand.ID into tmp
                     from b in tmp.DefaultIfEmpty()
                     orderby p.Price
                     select new
                     {
                         ten = p.Name,
                         gia = p.Price,
                         thuonghiue =(b!=null)? b.Name : "ko co th",
                     };
            qr.ToList().ForEach(o =>
            {
                Console.WriteLine($"{o.ten,10} {o.thuonghiue,15} {o.gia,5}");
            });



        }
    }
}
