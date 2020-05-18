using Coding.Exercise;
using NUnit.Framework;

namespace FlyWeightTests
{
    [TestFixture]
    public class SentenceTests
    {
        [Test]
        public void Test()
        {
            var s = new Sentence("alpha beta gamma");
            s[1].Capitalize = true;
            Assert.That(s.ToString(),
              Is.EqualTo("alpha BETA gamma"));
        }
    }
}