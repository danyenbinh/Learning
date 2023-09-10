using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Action<string> Thongbao;
            
            Thongbao=(string s) => Console.WriteLine(s); //

            Thongbao?.Invoke("Xin chao");*/


            /*Action thongbao;
            thongbao = () => Console.WriteLine("Xin chao cac ban");
            thongbao?.Invoke();*/

            Action<string> welcome;
            welcome = (string s) => Console.WriteLine(s);
            welcome?.Invoke("xinchao");

            /*(int a,int b) =>
            {
                int kq = a + b;
                return kq;
            }*/




        }
    }
}
