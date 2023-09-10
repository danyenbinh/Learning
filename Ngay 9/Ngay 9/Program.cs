using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay_9
{
    public delegate void Sukiennhapso(int x);
    class Dulieunhap : EventArgs
    {
        public int data { set; get; }
        public Dulieunhap(int x) => data = x;
    }
    class Userinput
    {
        //public event Sukiennhapso sukiennhapso;
        public event EventHandler sukiennhapso; // ~ delegate void kieu(object? sender, EventArgs args)
        public void Input()
        {
            do
            {
                Console.WriteLine("Nhap vao 1 so nguyen");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                //Phat di su kien
                sukiennhapso?.Invoke(this,new Dulieunhap(i) );
            } while (true);
        }
    }
    class Tinhcan
    {
        public void Sub(Userinput input)
        {
            input.sukiennhapso += Can;
        }
        public void Can(object sender,EventArgs e)
        {
            Dulieunhap dulieunhap = (Dulieunhap)e;
            int i = dulieunhap.data;
            Console.WriteLine($"Can bac 2 cua so {i} la:{Math.Sqrt(i)}");
        }
    }
    class Binhphuong
    {
        public void Sub(Userinput input)
        {
            input.sukiennhapso += bp;
        }
        public void bp(object sender, EventArgs e)
        {
            Dulieunhap dulieunhap = (Dulieunhap)e;
            int i = dulieunhap.data;
            Console.WriteLine($"binh phuong cua so {i} la:{Math.Pow(i,2)}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.CancelKeyPress += (sender, e) =>
            {
                Console.WriteLine("Thoat ung dung");
            };
            //publicsher
            Userinput userinput = new Userinput();

            userinput.sukiennhapso += (sender,e) =>
            {
                Dulieunhap dulieunhap = (Dulieunhap)e;
                Console.WriteLine("Ban vua nhap so: "+dulieunhap.data);
            };

            // subcriber
            Tinhcan tinhcan = new Tinhcan();
            tinhcan.Sub(userinput);

            Binhphuong bphuong = new Binhphuong();
            bphuong.Sub(userinput);


            userinput.Input();


        }
    }
}
