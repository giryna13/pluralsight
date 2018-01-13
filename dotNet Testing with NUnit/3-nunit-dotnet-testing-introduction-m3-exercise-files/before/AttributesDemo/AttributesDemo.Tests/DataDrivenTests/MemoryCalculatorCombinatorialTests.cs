using NUnit.Framework;

namespace AttributesDemo.Tests.DataDrivenTests
{  
    [TestFixture]
    public class MemoryCalculatorCombinatorialTests
    {        
        [Test]
        public void ShouldAddAndDivide(
            int numToAdd, 
            int numToDivideBy)
        {
            var sut = new MemoryCalculator();

            sut.Add(numToAdd);

            sut.Divide(numToDivideBy);
        }
    }
}
