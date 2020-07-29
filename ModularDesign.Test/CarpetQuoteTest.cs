using NUnit.Framework;

namespace ModularDesign.Test
{
    [TestFixture]
    public class CarpetQuoteTest
    {
        [Test]
        public void PriceOfFittedCarpetUnrounded()
        {
            CarpetQuote quote = new CarpetQuote();
            Assert.AreEqual(577.50, 
                quote.FittedPrice(10.5, 5.5, 10.0, false));
        }
        
        [Test]
        public void PriceOfFittedCarpetRoundedUp()
        {
            CarpetQuote quote = new CarpetQuote();
            Assert.AreEqual(580.0, 
                quote.FittedPrice(10.5, 5.5, 10.0, true));
        }
    }
}