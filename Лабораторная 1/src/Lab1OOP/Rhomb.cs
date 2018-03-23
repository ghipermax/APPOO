using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1OOP
{
    class Rhomb : Shape
    {
        public Rhomb(int a, int b) : base(a, b)
        {
        }
        public override int area()
        {
            Console.WriteLine("Rhomb class area :");
            return (width * height / 2);
        }
    }
}
