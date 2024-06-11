using NepaliNumberToWord;

namespace NumberConversionTests
{
    public class DigitTOWordsTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void DigitToWordsEqualTest()
        {
            // Assign
            string expected = "Ninety Nine";

            // Act
            string actual = CSConversionLogic.DigitToWord(99);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DigitToWordsMaxTest()
        {
            // Assign
            string expected = "";

            // Act
            string actual = CSConversionLogic.DigitToWord(99999999999999);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(10000000000000)]
        public void DIgitToWord_NotEqualsTest(long number)
        {
            string expected = "One Shankha";

            string actual = CSConversionLogic.DigitToWord(number);

            Assert.That(actual, Is.Not.EqualTo(expected));
        }
    }
}
