using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay2
{
    class Program
    {

        /*public static void binhphuong(int a, out int kq)
        {
            kq = a * a;
            Console.WriteLine(a);
        }
        public static void Main(string[] args)
        {
            xinchao(ho:"Mai VIet",ten: "Hoang");
            int a = 34, b = 45;
            float x = 3.4f, y = 4.6f;
            Console.WriteLine(TInhtoan.Tinhtoan.tong(a, b));
            Console.WriteLine(TInhtoan.Tinhtoan.tong(x, y));
            int c;
            binhphuong(4, out c);
            Console.WriteLine(c);

        }

        static void xinchao(string ten, string ho)
        {
            string fullname;
            fullname = ho + " " + ten;
            Console.WriteLine($"XIn chao {fullname}");
        }*/

        static void Main(string[] args)
        {
            Vukhi sungluc; //null
            sungluc = new Vukhi();
            sungluc.name = "sung luc: ";
            sungluc.Thietlaptnacong(5);
            sungluc.Noisanxuat = "My";

            Console.WriteLine(sungluc.Noisanxuat);


            Vukhi sungmay = new Vukhi("sung may",10);
            sungluc.tancong();
            sungmay.tancong();

        }





    }
}
