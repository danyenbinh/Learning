using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay9._3
{
    class CoutNumber
    {
        public static int number = 0;
        public static void Infor()
        {
            Console.WriteLine("So lan truy cap: "+number);
        }
        public void Count()
        {
            CoutNumber.number++;
        }
    }
    class Student
    {
        public readonly string name;
        public Student(string _name)
        {
            this.name = _name;
        }
    }
    class Vector
    {
        double x, y;
        public Vector(double _x,double _y)
        {
            x = _x;
            y = _y;
        }
        public void Info()
        {
            Console.WriteLine($"x={x},y={y}");
        }

        public static Vector operator+(Vector v1,Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y);
        }
        public double this[int i]
        {
            set
            {
                switch (i)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    default:
                        throw new Exception("Chi so bi sai");
                        
                }
            }

            get
            {
                switch (i)
                {
                    case 0:
                        return x; 
                        
                    case 1:
                        return y;
                        
                    default:
                        throw new Exception("Chi so bi sai");
                        
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*CoutNumber c1 = new CoutNumber();
            CoutNumber c2 = new CoutNumber();
            c1.Count();
            c2.Count();
            CoutNumber.Infor();*/

            /* Student s = new Student("MVH");
             //s.name ="NVA";
             Console.WriteLine(s.name);*/

            /*Vector v1 = new Vector(2, 3);
            Vector v2 = new Vector(1, 1);

            var v3 = v1 + v2;
            v1.Info();
            v2.Info();
            v3.Info();*/

            Vector v = new Vector(2, 3);
            v[0] = 5;
            v[1] = 6;

            v.Info();

            //v[0]~x
            //v[1]~y



        }
    }
}
