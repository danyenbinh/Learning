using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Ngay_9._2
{
    //extension method
    static class Abc
    {
        public static void Print(this string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        }
    }
    class Program
    {
        public static void Print(string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            /*int[] mang = { 1, 2, 42, 5, 6 };
            int max = mang.Max();
            Console.WriteLine(max);*/
            /*string s = "xcadasda";
            s.Print(ConsoleColor.Green);
            Print(s, ConsoleColor.Red);
            Print(s, ConsoleColor.Yellow);*/
            /*"Xin".Print(ConsoleColor.Red);
            "Chao".Print(ConsoleColor.Yellow);*/
            double a = 2.5;
            Console.WriteLine(a.Binhphuong());
        }
    }
}
