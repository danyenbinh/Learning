using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay6
{
    //abstract  
    abstract class product
    {
        protected double Price { set; get; }
        public abstract void Productinfo();
        
        public void Tesst() => Productinfo();
    }

    class iphone : product
    {
        public iphone() => Price = 500;
        public override void Productinfo()
        {
            Console.WriteLine($"Dien thoai Iphone: {Price}");
            //base.Productinfo();
            Console.WriteLine("Hi");

        }

    }
    
    //Interface
    interface IHinhHoc
    {
        public double chuvi();
        public double dientich();

    }
    class Hinhchunhat : IHinhHoc
    {
        public Hinhchunhat(double _a, double _b)
        {
            a = _a;
            b = _b;
        }
        public double a { set; get; }
        public double b { set; get; }

        public double chuvi()
        {
            return 2 * (a + b);
        }

        public double dientich()
        {
            return a * b;
        }
    }
   
    class Program
    {
       
        static void Main(string[] args)
        {
            //iphone i = new iphone();
            //i.Tesst();
            Hinhchunhat h = new Hinhchunhat(4, 5);
            Console.WriteLine($"Dien tich: {h.dientich()}, Chu vi: {h.chuvi()}");

        }
    }
}
