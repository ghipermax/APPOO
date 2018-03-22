using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_ISP_bad
{
    public class Jeep : ICarDescription
    {
        double jeepPrice = 110;
        public string GetDescription()
        {
            return " jelaete Jeep";
        }
        public string GetColor()
        {
            return " V nalicii esti krasnii tvet";
        }
        public double GetPrice()
        {
            return jeepPrice;
        }
        public double CalculatePriceAfterTax()
        {
            return jeepPrice + jeepPrice * .20;
        }
    }
    public class Sedan : ICarDescription
    {
        double sedanPrice = 200;
        public string GetDescription()
        {
            return " You get a Laptop";
        }
        public string GetColor()
        {
            return " Color is Black and Red";
        }
        public double GetPrice()
        {
            return sedanPrice;
        }
        public double CalculatePriceAfterTax()
        {
            return sedanPrice + sedanPrice * .20;
        }
    }
    public class Hatchback : ICarDescription
    {
        double hatchbackPrice = 500;
        public string GetDescription()
        {
            return " jelaete Hatchback";
        }
        public string GetColor()
        {
            return " V nalicii esti sinii tvet";
        }
        public double GetPrice()
        {
            return hatchbackPrice;
        }
        public double CalculatePriceAfterTax()
        {
            return hatchbackPrice + hatchbackPrice * .20;
        }
    }

    public class GiftItem : ICarDescription
    {
        public string GetDescription()
        {
            return "Da vi poluciaete odin iPhone v kacestve podarca";
        }
        public string GetColor()
        {
            return "Mi predlogaem vam tveta - black onyx, black, silvery!";
        }
        public double GetPrice()
        {
            return 0;
        }

        public double CalculatePriceAfterTax()
        {
            return 0;
        }
    }

    public class Shop
    {
        public string GetMyCar(ICarDescription cmptype)
        {
            // No matter how many types of computer comes 
            var myCar = cmptype.GetDescription();
            return myCar;
        }
        public string GetMyComputerPrice(ICarDescription cmptype)
        {
            var myCarpprice = "Tena : " + cmptype.CalculatePriceAfterTax().ToString();
            return myCarpprice;
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
