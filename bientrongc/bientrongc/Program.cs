using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bientrongc
{
    class Program
    {
        static void Main(string[] args)
        {
            baitap();
         


        }
        static void bai1()
        {
            Console.WriteLine("toi ten khanh");
            Console.ReadKey();

        }
        static void bai6()
        {
            int a = 5, b = 5, c = 10, d = 15;

            Console.WriteLine(a++);
            Console.WriteLine(--b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a < b);
            Console.ReadKey();

        }
        static void bai7()
        {
            const int x = 10;
            Console.WriteLine(x);
            Console.ReadKey();
        }
        static void bai8()
        {
            int i = 300;
            byte b = (byte)i;
            Console.WriteLine("i = " + i);
            Console.WriteLine("b = " + b);
            Console.ReadKey();
        }
        static void bai9()
        {
            string  K = "Kteam";

            if (K =="Kteam2")
                Console.WriteLine("Free Education");
            else
                Console.WriteLine(" connecting to . . .");
            Console.ReadKey();
        }
        static void baitap()
        {
            string A = "2";
            if (A == "3")
                Console.WriteLine(" có 1 chu so la 2");
            else
                Console.WriteLine(" khong phai chu so ");
            Console.ReadKey();
        }
  
        }

    }
