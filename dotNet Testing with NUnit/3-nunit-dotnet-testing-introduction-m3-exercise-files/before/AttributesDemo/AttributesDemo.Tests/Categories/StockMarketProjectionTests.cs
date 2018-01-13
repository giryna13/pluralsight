using NUnit.Framework;

namespace AttributesDemo.Tests.DataDrivenTests
{  
    [TestFixture]
    public class StockMarketProjectionTests
    {        
        [Test]        
        public void ShouldProjectShortTerm()
        {
            var sut = new StockMarketProjection();

            var marketValue = sut.CalculateShortTerm();

            Assert.That(marketValue, Is.EqualTo(200));
        }


        [Test]
        public void ShouldProjectLongTerm()
        {
            var sut = new StockMarketProjection();

            var marketValue = sut.CalculateLongTerm();

            Assert.That(marketValue, Is.EqualTo(50));
        }
    }
}
