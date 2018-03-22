using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_ISP
{
    class GiftItem : ICarDescription
    {
        public string GetColor()
        {
            return "Мы предлогаем вам цвета - black onyx, black, silvery!";
        }

        public string GetDescription()
        {
            return "Да вы получаете один iPhone в качестве подарка";
        }
    }
}
