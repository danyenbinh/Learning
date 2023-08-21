using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string studentName="MVH";
            int age = 20;
            char a;
            bool b=true;
            float c;
            c = (float)12.12;
            object m;
            m = studentName;
            double so_pi = 3.14;
            double hai_pi = so_pi * 2;
            Console.WriteLine(hai_pi);*/

            Console.Title = "vd nhap xuat";
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.Green;

            /*string havaten;
            Console.Write("halo:");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("new");
            Console.Write("Nhap ho va ten: ");
            havaten = Console.ReadLine();
            Console.WriteLine("Xin chao {0}", havaten);

            float a, b;
            string sinput;
            Console.WriteLine("Hay nhap tham so a:");
            sinput = Console.ReadLine();
            a = float.Parse(sinput);

            Console.WriteLine("Hay nhap tham so b:");
            sinput = Console.ReadLine();
            b = Convert.ToSingle(sinput);

            Console.WriteLine("So a= {0}, b={1}", a, b);

            var h = "dasdas";
            h = "adasdasda";*/

            /*float a, b,max,c=9;
            Console.WriteLine("Nhap a va b: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            max=(a > b) ? (a>c)?a:c : (b>c)?b:c;
            Console.WriteLine("max={0} ",max);*/

            /*int[] a;
            a = new int[3];

            for(int i = 0; i <= 2; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }


            for(int i = 0; i <= 2; i++)
            {
                Console.WriteLine(a[i]);
            }*/

            //int[] numbers = { 1, 4, 2, 5, 2, 3, 8 };
            /*foreach(var abc in numbers)
            {
                Console.WriteLine(abc);
            }*/
            /*Console.WriteLine($"so phan tu: {numbers.Length}");
            Console.WriteLine($"Chieu: {numbers.Rank}");
            Console.WriteLine($"Min: { numbers.Min()}");
            Console.WriteLine($"Max: { numbers.Max()}");
            Console.WriteLine($"Sum: { numbers.Sum()}");

            Array.Sort(numbers);
            foreach (var abc in numbers)
            {
                Console.WriteLine(abc);
            }*/
            /*double[,] a = new double[2, 3] { { 2, 3, 4 }, { 5, 6, 7 } };
            int hang = 2;
            int cot = 3;
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }*/

            string hoten="";
            int tuoi=0;
            int MSV=0;
            int chon;
            do
            {
                Console.WriteLine("-----------Menu-----------");
                Console.WriteLine("1 - Nhap ho va ten");
                Console.WriteLine("2 - Nhap so tuoi");
                Console.WriteLine("3 - Nhap ma sinh vien");
                Console.WriteLine("4 - Xuat");
                Console.WriteLine("--------------------------");
                chon = int.Parse(Console.ReadLine());
                switch(chon){
                    case 1:
                        Console.WriteLine("Nhap ho va ten:");
                        hoten = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Nhap tuoi: ");
                        tuoi = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Nhap ma sinh vien");
                        MSV = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Chon so khac");
                        break;
                }
            } while (chon != 4);
            Console.WriteLine($"Ho va ten:{ hoten}");
            Console.WriteLine($"Tuoi: {tuoi}");
            Console.WriteLine($"MSV: {MSV}");



        }

    }
}

