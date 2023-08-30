using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay5._2
{
    class Program
    {
        class Abc
        {
            public void xinChao() => Console.WriteLine("Xin chao C#");
        }
        static void Main(string[] args)
        {
            Abc a = new Abc();
            a = null;
            a?.xinChao();
            int? age;
            age = null;
            age = 100;
            if (age.HasValue)
            {
                int _age = age.Value;
                Console.WriteLine(_age);
            }
        }
    }
}
