using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay3._2
{
    class Animal
    {
        public int legs { set; get; }
        public float weight { set; get; }
        public Animal()
        {
            Console.WriteLine("Khoi tao animal");
        }
        public Animal(string abc)
        {
            Console.WriteLine($"khoi tao animal (2)-{abc}");
        }
        public void Showlegs()
        {
            Console.WriteLine($"legs: {legs}");

        }

    }
    class Cat : Animal
    {
        public string food;

        public Cat(string s) : base(s)
        {
            this.legs = 4;
            this.food = "fish";
            Console.WriteLine("Khoi tao Cat");
        }
        public void Eat()
        {
            Console.WriteLine(food);
        }
        public new void Showlegs()
        {
            Console.WriteLine($"Loai meo co so chan la: {legs}");

        }
        public void ShowInfor()
        {
            base.Showlegs();
            Showlegs();
        }
    }
    class A { }
    class B:A { }
    class C:B { }

    class Program
    {
        /*public struct Product
        {
            public string name;
            public double gia;

            public string infor
            {
                get{
                    return $"{name}, {gia}";
                }
            }
            public string Getinfo()
            {
                return $"Ten san pham {name}, gia: {gia}$";
            }
            public Product(string _name, double _price)
            {
                name = _name;
                this.gia = _price;
            }

        }
        static void Main(string[] args)
        {
            Product sanpham1;
            sanpham1.name = "ip5";
            sanpham1.gia = 1000;

            Product sanpham2 = new Product("ip7", 10000);

            Console.WriteLine(sanpham1.Getinfo());
            Console.WriteLine(sanpham2.Getinfo());
            Console.WriteLine(sanpham2.infor);

        }*/



        //enum
        /*enum Hocluc { 
            kem =2, //0
            trungbinh=5, //1 
            kha=7, //2
            gioi=8 //3
        }
        static void Main(string[] args)
        {
            Hocluc hocluc;
            //hocluc = Hocluc.gioi;
            hocluc = (Hocluc)(7);

            switch (hocluc)
            {
                case Hocluc.kem:
                    Console.WriteLine("kem");
                    break;
                case Hocluc.trungbinh:
                    Console.WriteLine("tb");
                    break;
                case Hocluc.kha:
                    Console.WriteLine("kha");
                    break;
                case Hocluc.gioi:
                    Console.WriteLine("gioi");
                    break;
            }
        }
        */


        //Tinhs kees thuwaf
        static void Main(string[] args)
        {
            Cat c = new Cat("ABC sux");
            c.ShowInfor();
            c.Eat();  
        }


    }
}
