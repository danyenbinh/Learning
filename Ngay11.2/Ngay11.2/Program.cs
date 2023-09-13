using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Queue<string> cachoso = new Queue<string>();
            cachoso.Enqueue("H1");
            cachoso.Enqueue("H2");
            cachoso.Enqueue("H3");

            foreach(var hs in cachoso)
            {
                Console.WriteLine(hs);
            }
            var hoso = cachoso.Dequeue();
            Console.WriteLine($"Xu ly ho so: {hoso}-{cachoso.Count}");
            var h = cachoso.Dequeue();
            Console.WriteLine($"Xu ly ho so: {hoso}-{cachoso.Count}");*/

            /*Stack<string> hanghoa = new Stack<string>();
            hanghoa.Push("1");
            hanghoa.Push("2");
            hanghoa.Push("3");
            hanghoa.Push("4");

            var mathang = hanghoa.Pop();
            Console.WriteLine($"Lay: {mathang} ");
            mathang = hanghoa.Pop();
            Console.WriteLine($"Lay: {mathang} ");
            mathang = hanghoa.Pop();
            Console.WriteLine($"Lay: {mathang} ");
            mathang = hanghoa.Pop();
            Console.WriteLine($"Lay: {mathang} ");
*/
            /*LinkedList<string> baihoc = new LinkedList<string>();
            var h1 = baihoc.AddFirst("1");
            var h2 = baihoc.AddLast("2");
            LinkedListNode<string> h3 = baihoc.AddAfter(h1,"3");
            baihoc.AddLast("4");
            foreach(var h in baihoc)
            {
                Console.WriteLine(h);
            }
            var node = h3;
            Console.WriteLine(node.Value);
            node = node.Next;
            Console.WriteLine(node.Value);

            var node1 = baihoc.Last;*/

            /*Dictionary<string, int> sodem = new Dictionary<string, int>()
            {
                ["one"] = 1,
                ["two"] = 2
                
            };
            sodem ["Three"] = 3;
*/
            /*var keys = sodem.Keys;
            foreach(var n in keys)
            {
                var value = sodem[n];
                Console.WriteLine($"{n}= {value}");
            }*/


            HashSet<int> set1 = new HashSet<int>() { 1, 2, 5, 6 };
            HashSet<int> set2 = new HashSet<int>() { 3, 2, 4, 7 };

            set1.UnionWith(set2);
            set1.IntersectWith(set2);

        }
    }
}
