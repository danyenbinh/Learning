using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay13._2
{
    /*class A
    {
        public void ActionA() => Console.WriteLine("Action in class A");
    }; 
    class B
    {
        public void ActionB()
        {
            Console.WriteLine("Action in class B");
            var a = new A();
            a.ActionA();
        }
    };*/
    interface IClassB
    {
        void ActionB();
    };
    interface IClassC
    {
        void ActionC();
    }
    class ClassC :IClassC
    {
        public void ActionC() => Console.WriteLine("Action in ClassC");   
    }

    class ClassB :IClassB
    {
        // Phụ thuộc của ClassB là ClassC
        IClassC c_dependency;

        public ClassB(IClassC classc) => c_dependency = classc;
        public void ActionB()
        {
            Console.WriteLine("Action in ClassB");
            c_dependency.ActionC();
        }
    }

    class ClassA
    {
        // Phụ thuộc của ClassA là ClassB
        IClassB b_dependency;

        public ClassA(IClassB classb) => b_dependency = classb;
        public void ActionA()
        {
            Console.WriteLine("Action in ClassA");
            b_dependency.ActionB();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*var b = new B(); 
            b.ActionB();*/
            IClassC objectC = new ClassC();
            IClassB objectB = new ClassB(objectC);
            ClassA objectA = new ClassA(objectB);

            objectA.ActionA();
            
        }
    }
}
