using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_ISP
{
    class Jeep : ICarDescription, ICarPrice
    {
        double jeepPrice = 15000;

        public string GetColor()
        {
            return " В наличии есть красный цвет";
        }

        public string GetDescription()
        {
             return " желаете Jeep";
        }

        public double GetPrice()
        {
            return jeepPrice;
        }
    }
}
