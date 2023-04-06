using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sells_Comission
{
    class comCalculation
    {
        private double percent1 = 5;
        private double percent2 = 10;
        private double percent3;

        public double FinalPriceCalc(double firstPrice, double productType)
        {
            double finalPrice = 0;

            switch(productType)
            {
                case 1:
                    finalPrice = firstPrice + (firstPrice * (percent1 / 100));
                    break;

                case 2:
                    finalPrice = firstPrice + (firstPrice * (percent2 / 100));
                    break;

                case 3:
                    finalPrice = firstPrice + (firstPrice * (percent3 / 100));
                    break;
            }

            return finalPrice;
        }
    }
}
