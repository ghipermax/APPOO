using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1OOP
{
    class Triangle : Shape
    {
        public Triangle(int a, int b) : base(a, b)
        {
        }
        public override int area()
        {
            Console.WriteLine("Triangle class area :");
            return (width * height / 2);
        }
    }
}
