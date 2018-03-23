using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1OOP
{
    class Rectangle : Shape { //наследование
        public Rectangle(int a, int b) : base(a, b) //Конструктор производного класса
        {

        }
        public override int area() //полиморфизм - различная реализация обьектов с одинаковой спецификацией
        {
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }
    }
}
