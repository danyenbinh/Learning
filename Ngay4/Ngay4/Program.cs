using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mynamespace;
using Xyz = Mynamespace.Abc;



namespace Ngay4
{
    class Program
    {
        static void Main(string[] args)
        {
            //class1.Xinchao();
            //Xyz.class1.Xinchao();
            Sanpham.product product = new Sanpham.product();
            product.name = "Ipad";
            product.price = 15000;
            product.description = "HANG AU";
            product.manufatory = new Sanpham.product.Manufactory();
            product.manufatory.name = "gogle";

            Console.WriteLine(product.Getinfor());
            
        }
    }
}
