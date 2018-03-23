using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Caller c = new Caller(); //создание обьектов
            Rectangle r = new Rectangle(10, 7); 
            Triangle t = new Triangle(10, 5);
            Rhomb rh = new Rhomb(20, 10);
            
            c.CallArea(r); //явное проявление полиморфизма
            c.CallArea(t);
            c.CallArea(rh);

            Console.ReadKey();
        }
    }
}
