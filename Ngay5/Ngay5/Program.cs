using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymus_example
{
    class Program
    {   
        class Svien
        {
            public string Ten { set; get; }
            public int Namsinh { set; get; }
            public string Noising { set; get; }
        }
        class student
        {
            public string Name { set; get; }
            public void Hello() => Console.WriteLine(Name);
        }
        static void inra(dynamic obj)
        {
            obj.Name = "adasdad";
            obj.Hello();
        }
        static void Main(string[] args)
        {
            /*var sanpham = new { Ten ="ip",gia=1000,namsx=2018};
            Console.WriteLine(sanpham.Ten);
            Console.WriteLine(sanpham.gia);
            Console.WriteLine(sanpham.namsx);
            List<Svien> cacsinhvien = new List<Svien>()
            {
                new Svien() {Ten ="A",Namsinh= 2000, Noising = "LC"} ,
                new Svien() { Ten = "B", Namsinh = 2001, Noising = "LC" },
                new Svien() { Ten = "C", Namsinh = 2002, Noising = "LC" },

            };
            var ketqua = from sv in cacsinhvien
                         where sv.Namsinh <= 2001
                         select new
                         {
                             Ten = sv.Ten,
                             NS = sv.Noising
                         };
            foreach(var sinhvien in ketqua)
            {
                Console.WriteLine(sinhvien.Ten + " - " + sinhvien.NS);
            }*/
            student a= new student();
            inra(a);
            dynamic tenbien;
            tenbien = new { };

            tenbien.asd = "asdad";
            Console.WriteLine(tenbien.asd);
        }
    }
}
