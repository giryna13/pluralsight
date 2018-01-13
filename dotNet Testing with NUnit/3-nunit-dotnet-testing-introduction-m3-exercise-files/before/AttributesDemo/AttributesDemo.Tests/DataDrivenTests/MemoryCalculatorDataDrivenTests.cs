using NUnit.Framework;

namespace AttributesDemo.Tests.DataDrivenTests
{  
    [TestFixture]
    public class MemoryCalculatorDataDrivenTests
    {        
        [Test]
        public void ShouldSubtractTwoNegativeNumbers()
        {
            var sut = new MemoryCalculator();

            sut.Subtract(-5);
            sut.Subtract(-10);

            Assert.That(sut.CurrentValue, Is.EqualTo(15));
        }



    }
}
