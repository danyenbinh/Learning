using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ngay12._2
{
    class Program
    {
        static void Dosmething(int seconds, string msg,ConsoleColor color)
        {
            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{msg,10} ...Start");
            }
            string a = "abc";
            //...
            lock (a)
            {
                //...
            }

            for (int i = 1; i <= seconds; i++)
            {
                lock (Console.Out)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine($"{msg,10} {i,3}");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }
            }
            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{msg,10} ...End");
                Console.ResetColor();
            }
        } 
        static async Task task2()
        {
            Task t2 = new Task(() => {
                Dosmething(10, "T2", ConsoleColor.Green);
            });
            t2.Start();
            await t2;
            Console.WriteLine("T2 complete");

           
        }
        static async Task task3()
        {
            Task t3 = new Task((object ob) =>
            {
                string tentacvu = (string)ob;
                Dosmething(4, tentacvu, ConsoleColor.Yellow);
            }, "T3");

            t3.Start();
            await t3;
            //t3.Wait();
            Console.WriteLine("T3 complete");
            
        }
        static async Task<string> task4()
        {
            Task<string> t4 = new Task<string>(() => {
                Dosmething(10, "T4", ConsoleColor.Red);
                return "return from T4";
            });
            t4.Start();

            var kq = await t4;
            Console.WriteLine("T4 complete");
            return kq;
        }
        static async Task<string> task5()
        {
            Task<string> t5 = new Task<string>((object ob) =>
            {
                string t = (string)ob;
                Dosmething(4, t, ConsoleColor.Cyan);
                return $"return from {t}";
            }, "T5");
            t5.Start();
            var kq1 = await t5;
            return kq1;

        }
        static async Task<string> Getweb(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage kq = await httpClient.GetAsync(url);
            string content = await kq.Content.ReadAsStringAsync();
            return content;
        }

        static async Task Main(string[] args)
        {
            var task = Getweb("https://www.facebook.com/profile.php?id=100050028152788");
            

            //Task<string> t4 = task4();
            //Task<string> t5 = task5();
            //Task t2 = task2();
            //Task t3 = task3();
            Dosmething(6, "T1", ConsoleColor.Magenta);
            //Dosmething(10, "T2", ConsoleColor.Gray);
            //Dosmething(4, "T3", ConsoleColor.Yellow);
            //t2.Wait();
            //t3.Wait();
            //Task.WaitAll(t2, t3);
            //await t2;
            //await t3;
            //Task.WaitAll(t4, t5);


            //var kq4 = await t4;
            //var kq5 = await t5;
            //Console.WriteLine(kq4);
            //Console.WriteLine(kq5);

            var content = await task;

            Console.WriteLine(content);
            Console.ReadKey();
        }
    }
}
