using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1OOP
{
    class Caller
    {
        public void CallArea(Shape sh) 
        {
            Console.WriteLine("Area: {0}", sh.area());
        }
    }
}
