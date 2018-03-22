using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_ISP
{
    interface IPriceCalculation
    {
        double CalculatePriceAfterTax(ICarPrice c);
    }
}
