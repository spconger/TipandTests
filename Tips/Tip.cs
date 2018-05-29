using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tips
{
    public class Tip
    {
        public double BillAmount { get; set; }
        public double TipPercent { get; set; }
        public double TaxPercent { get; set; }

        public double CalculateTip()
        {
            if(TipPercent > 1)
            {
                TipPercent /= 100;
            }
            return BillAmount * TipPercent;
        }

        public double CalculateTax()
        {
            return BillAmount * TaxPercent;
        }

        public double CalculateTotal()
        {
            return BillAmount + CalculateTip() + CalculateTax();
        }

    }
}
