using NUnit.Framework;

namespace AttributesDemo.Tests.DataDrivenTests
{  
    [TestFixture]
    public class ClassWithIntermittentBugTests
    {        
        [Test]
        public void ShouldProjectShortTerm()
        {
            var sut = new ClassWithIntermittentBug();

            sut.DoWork();            
        }
    }
}
