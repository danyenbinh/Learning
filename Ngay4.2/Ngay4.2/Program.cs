using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay4._2
{
    class Program
    {
        
        /*static void swarp<T>(ref T a,ref T b)
        {
            T tam;
            tam = a;
            a = b;
            b = tam;
        }*/
        class Product<A>
        {
            A ID;
            public void SetID(A _id)
            {
                this.ID = _id;
            }
            public void In()
            {
                Console.WriteLine($"ID: {ID}");
            }
        }
        static void Main(string[] args)
        {
            /*string a = "ac";
            string b = "mh";
            swarp<string>(ref a,ref b);

            Console.WriteLine($"{a} va {b}");*/
            Product<int> sanpham1 = new Product<int>();
            sanpham1.SetID(123);
            sanpham1.In();

            Product<string> sanpham2 = new Product<string>();
            sanpham2.SetID("asdqwdqd");
            sanpham2.In();

            List<int> list1 = new List<int>();
            List<string> list2 = new List<string>();

            Stack<int> stack1 = new Stack<int>();


        }
    }
}
