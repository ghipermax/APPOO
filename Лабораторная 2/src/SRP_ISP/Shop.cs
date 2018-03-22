using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_ISP
{
    class Shop
    {
        public string GetMyCar(ICarDescription cmptype)
        {
            // No matter how many types of car comes 
            var myCar = cmptype.GetDescription();
            return myCar;
        }
        public string GetMyCarPrice(IPriceCalculation cmpCal, ICarPrice cmpPrice)
        {
            var myCarprice = " цена: " +
                     cmpCal.CalculatePriceAfterTax(cmpPrice).ToString();
            return myCarprice;
        }
        public string GetAvailableColor(ICarDescription cmptype)
        {
            var myCarcolor = cmptype.GetColor().ToString();
            return myCarcolor;
        }
        public string WhatIsThecolorofGiftItem(ICarDescription cmptype)
        {
            return GetAvailableColor(cmptype);
        }
        public string IsThereAnyGiftItem(ICarDescription gftType)
        {
            return GetMyCar(gftType);
        }
    }
}
