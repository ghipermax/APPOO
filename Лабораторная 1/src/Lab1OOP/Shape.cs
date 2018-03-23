using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1OOP
{
    abstract class Shape { //абстрактный класс

        protected int width, height; //инкапсуляция - можем изменять данные в дочерник классах

        public Shape(int a, int b)
        {
            width = a;
            height = b;
        }
        public abstract int area(); //не нужно реализовать этот метод в базовом абстрактном классе 
    }
}


