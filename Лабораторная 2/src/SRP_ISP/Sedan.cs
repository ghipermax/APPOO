using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_ISP
{
    class Sedan : ICarDescription, ICarPrice
    {
        double sedanPrice = 5000;

        public string GetColor()
        {
             return " В наличии есть черный цвет";
        }

        public string GetDescription()
        {
            return " желаете Sedan";
        }

        public double GetPrice()
        {
            return sedanPrice;
        }
    }
}
