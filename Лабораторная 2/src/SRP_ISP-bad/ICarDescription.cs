﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_ISP_bad
{
    public interface ICarDescription
    {
        string GetDescription();
        string GetColor();
        double GetPrice();
        double CalculatePriceAfterTax();

    }
}
