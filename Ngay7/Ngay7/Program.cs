using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay7
{
    class Program
    {
        public delegate void Showlog(string message);
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        delegate int kieu1();
        static int Tong(int a, int b) => a + b;

        static void Main(string[] args)
        {
            Showlog log = null;
            log = Info;
            log("Xin chao");

            log += Warning;
            log?.Invoke("Xinchaoabc");

            Action action;
            Action<string, int> action1;// delegate void kieu(string s,int i)
            Action<string> action2;

            action2 = Warning;
            action2.Invoke("asdasdas");

            Func<string> f1; //delegate int kieu();
            Func<string,double,string> f2;
            Func<int, int, int> f3;
            int a = 5;
            int b = 10;
            f3 = Tong;
            Console.WriteLine(f3(a, b));

            

        }
    }
}
