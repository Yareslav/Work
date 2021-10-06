using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.ComponentModel.Design;
using Task1;
using Task2;
using Task3;
using Task4;

namespace ConsoleApplication12
{
    
    class Program
    {
        static void Task1()
        {
            var redPiranha = new Piranha(122, 900, "red", "pirot");
            redPiranha.GetFish();
            var yeloowBar = new Fish(100, 200, "yellow");
            yeloowBar.GetFish();
        }
        static void Task2()
        {
            new A(new B1(), new B2(), new B3());
            new A(new B1(), new B2());
        }
        static void Task3 () {

            void LogPoly<T>(T obj)
            {
                var myField = obj.GetType().GetFields();
                Debug.Write("new object");
                for (var i = 0; i <myField.Length; i++)
                {
                    Debug.Write($"{myField[i].Name}:{myField[i].GetValue(obj)}");
                }
            }
            LogPoly(new b());
            LogPoly(new b1());
            LogPoly(new b2());
            LogPoly(new b3());
        }
        static void Task4()
        {
            Console.WriteLine("write trial");
            var trial = Console.ReadLine();
            Console.WriteLine("write keyNumber");
            var keyNumber = Console.ReadLine();
            Console.WriteLine("write pro");
            var pro = Console.ReadLine();
            new ApplicationLicense(trial,keyNumber,pro);
        }
        static void Main()
        {
            //Task1();
            Task2();
            //Task3();
            //Task4();
        }
    }
}