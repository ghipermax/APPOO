using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Shop sh = new Shop();
            Sedan sd = new Sedan();
            Hatchback hb = new Hatchback();
            GiftItem g = new GiftItem();*/

            var queryforSedan = new Sedan();
            var queryforHatchback = new Hatchback();
            var carShop = new Shop();
            var responsibleforCalculation = new CalculateCarPrice();
            var queryforGiftItem = new GiftItem();

            var sedanType = carShop.GetMyCar(queryforSedan);
            var hatchbacType = carShop.GetMyCar(queryforHatchback);
            var priceAnswerSedan = carShop.GetMyCarPrice(responsibleforCalculation, queryforSedan);
            var priceAnswerHatchback = carShop.GetMyCarPrice(responsibleforCalculation, queryforHatchback);
            var anyGiftAnswer = carShop.IsThereAnyGiftItem(queryforGiftItem);
            var colorAnswer = carShop.WhatIsThecolorofGiftItem(queryforGiftItem);
            var myAnswer1 = carShop.GetAvailableColor(queryforSedan);
            /*var myAnswer2 = carShop.GetMyCarPrice(responsibleforCalculation, queryforHatchback);*/

            Console.WriteLine(" Pocupateli: В какую цену у вас Sedan и Hatchback?");
            Console.WriteLine(" Prodaveti: " + priceAnswerSedan + " за Sedan и за Hatchback" + priceAnswerHatchback);
            Console.WriteLine(" Prodaveti: " + sedanType + " или" + hatchbacType + "?");
            Console.WriteLine(" Pocupateli: Если я покупаю Sedan, будет подарок или скидка?");
            Console.WriteLine(" Prodaveti: " + anyGiftAnswer);
            Console.WriteLine(" Pocupateli: Какие цвета машин типа Sedan есть в наличии?");
            Console.WriteLine(" Prodaveti: " + myAnswer1);
            Console.WriteLine(" Pocupateli: А какие цвета iPhone есть?");
            Console.WriteLine(" Prodaveti: " + colorAnswer);


            Console.ReadKey();
        }
    }
}
