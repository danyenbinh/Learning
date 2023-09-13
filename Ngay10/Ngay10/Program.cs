using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyException;
namespace Ngay10
{
    class Program
    {
        static void Register(string name, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
               
                throw new NameEmptyException();
            }else if(age <18 || age >100){
                throw new AgeException(age);

            }
            Console.WriteLine($"Xin chao {name} ({age})");
        }
        static void Main(string[] args)
        {

            try
            {
                Register("asd",10 );
            }
            
            catch(NameEmptyException nee)
            {
                Console.WriteLine(nee.Message);
            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message);
                e.Detail();
            }
            /*int a = 5, b = 0;
            try
            {
                var c = a / b;
                Console.WriteLine(c);
                int[] i = { 1, 2 };
                var x = i[5];
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine("Loi");
            }
            catch(IndexOutOfRangeException e2)
            {
                Console.WriteLine(e2.Message);
                Console.WriteLine("Chi so mang ko hopw le");
            }
            catch(Exception e1) 
            {
                Console.WriteLine(e1.Message);
                Console.WriteLine(e1.GetType().Name);
            }
            Console.WriteLine("KT chuong trinh");*/

        }
    }
}
