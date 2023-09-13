using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay10._2
{
    class A : IDisposable
    {
        bool resource = true;
        public void Dispose()
        {
            Console.WriteLine("Phuong thuc nay goi la tu dong khi su dung using");
            resource = false;
        }
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            using (Writedata writedata  = new Writedata("filename.txt"))
            {
                Console.WriteLine("dkasda");
            }
        }
    }
}
