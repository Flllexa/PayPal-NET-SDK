﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayPal;
using PayPal.Api;

namespace PayPal.UnitTest
{
    [TestClass()]
    public class FundingInstrumentTest
    {
        public static FundingInstrument GetFundingInstrument()
        {
            FundingInstrument instrument = new FundingInstrument();
            instrument.credit_card = CreditCardTest.GetCreditCard();
            return instrument;
        }

        [TestMethod()]
        public void FundingInstrumentConvertToJsonTest()
        {
            Assert.IsFalse(GetFundingInstrument().ConvertToJson().Length == 0);
        }

        [TestMethod()]
        public void FundingInstrumentToStringTest()
        {
            Assert.IsFalse(GetFundingInstrument().ToString().Length == 0);
        }
    }
}
