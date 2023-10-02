using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNomer3
{
     class Converter
    {
        private readonly decimal USD_to_UAH;
        private readonly decimal EUR_to_UAH;
        public Converter(decimal USD, decimal EUR) 
        {
            this.USD_to_UAH = USD;
            this.EUR_to_UAH = EUR;
        }

        public decimal HrivniaToDollar(double hrivnias)
        {
            return decimal.Round((decimal)hrivnias / USD_to_UAH, 2);
        }

        public decimal HrivniaToEuro(double hrivnias)
        {
            return decimal.Round((decimal)hrivnias / EUR_to_UAH, 2);
        }

        public decimal DollarToHrivnia(double dollars)
        {
            return (decimal)dollars * USD_to_UAH;
        }

        public decimal EuroToHrivnia(double euros)
        {
            return (decimal)euros * EUR_to_UAH;
        }

    }
}
