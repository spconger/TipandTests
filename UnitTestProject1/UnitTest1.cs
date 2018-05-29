using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Tip t = new Tip();
        [TestMethod]
        public void CalcTipTest()
        {
            t.BillAmount = 100;
            t.TipPercent = .20;
            double tipAmount = t.CalculateTip();
            Assert.AreEqual(tipAmount, 20);
        }

        [TestMethod]
        public void CalcTotalTest()
        {
            t.BillAmount = 100;
            t.TipPercent = .20;
            t.TaxPercent = 9;
            double taxAmount = t.CalculateTax();
            Assert.AreEqual(t.CalculateTotal(), 129.00);
        }
    }
}
