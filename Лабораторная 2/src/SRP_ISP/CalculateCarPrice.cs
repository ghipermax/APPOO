using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_ISP
{
    class CalculateCarPrice : IPriceCalculation // данный класс несет отвественность за вычисление цены
    {
        public double CalculatePriceAfterTax(ICarPrice c)
        {
            return c.GetPrice() + c.GetPrice() * 0.2;
        }
    }
}
