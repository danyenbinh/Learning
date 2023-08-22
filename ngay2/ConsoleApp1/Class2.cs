using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay2
{
    internal class Vukhi
    {
        public string name = "ten vu khi";
        public int dosatthuong = 0;


        //Thuoc tinh
        public string Noisanxuat { set; get; }
        public int Satthuong
        {
            //=
            set
            {
                dosatthuong = value;
            }
            //truycap
            get
            {
                return dosatthuong;
            }
        }
        public Vukhi()
        {
            Console.WriteLine("Khoi tao");
            dosatthuong = 1;
        }
        public Vukhi(string name, int _dosatthuong)
        {
            dosatthuong = _dosatthuong;
            this.name = name;
        } 
        public void Thietlaptnacong(int dosatthuong)
        {
            this.dosatthuong = dosatthuong;
        }
        public void tancong()
        {
            Console.Write($"{name}: \t");
            for (int i = 0; i < dosatthuong; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
