using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticAndInstance
{
    class Circle
    {
        static float _PI;
        int _Radius;
        static Circle()
        {
            Console.WriteLine("Static Contrustor Called.");
            Circle._PI = 3.14F;
        }
        public Circle(int radius)
        {
            Console.WriteLine("Instance Contrustor Called.");
            this._Radius = radius;
        }
        public float GetArea()
        {
            return Circle._PI * this._Radius * this._Radius;
        }
        ~Circle()
        {
            //Clean up code
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float area = c1.GetArea();

            Circle c2 = new Circle(6);
            float f = c2.GetArea();
            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Area ={0}", f);

            Console.ReadLine();
        }
    }
}
