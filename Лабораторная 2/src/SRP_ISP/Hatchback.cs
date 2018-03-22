using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_ISP
{
    class Hatchback : ICarDescription, ICarPrice
    {
        double hatchbackPrice = 8000;

        public string GetColor()
        {
            return " В наличии есть синий цвет";
        }

        public string GetDescription()
        {
            return " желаете Hatchback";
        }

        public double GetPrice()
        {
            return hatchbackPrice;
        }
    }
}
