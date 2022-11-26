using NUnit.Framework.Internal;
using UnitCalculator;

namespace TestCalculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SeedDoubleTest()
        {
            var calc1 = new SeededCalculator(1);
            var calc2 = new SeededCalculator(1);

            var rand1 = calc1.GetRandomDouble();
            var rand2 = calc2.GetRandomDouble();

            Assert.AreEqual(rand1, rand2);
        }
        [Test]
        public void SeedIntTest()
        {
            var calc1 = new SeededCalculator(1);
            var calc2 = new SeededCalculator(1);

            var rand1 = calc1.GetRandomInt();
            var rand2 = calc2.GetRandomInt();

            Assert.AreEqual(rand1, rand2);
        }

        [Test]
        public void MultiplyTest()
        {
            var calc = new SeededCalculator();
            var actual = calc.Multiply(3, 2);

            var expected = 6;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DivideFailTest()
        {
            try
            {
                var calc = new SeededCalculator();
                var res = calc.Divide(1, 0);
            }
            catch(DivideByZeroException ex)
            {
                Assert.Pass();
            }
            catch(Exception other)
            {
                Assert.Fail();
            }
        }
        [Test]
        public void DivideExceptionFailTest()
        {

            Assert.Throws<DivideByZeroException>(() =>
            {
                var calc = new SeededCalculator();
                var res = calc.Divide(1, 0);
            });
        }

        [Test]
        [TestCase("Hello!",6)]
        [TestCase("bro",3)]
        [TestCase("EPAM",4)]
        public void StringLengthTest(string str, int expectedLength)
        {
            var calc = new SeededCalculator();

            var actualLength = calc.StringLength(str);

            Assert.AreEqual(expectedLength, actualLength);
        }
        [Test]
        [TestCaseSource(typeof(DataProvider))]
        public void SinSourceTest(double radian, double expectedValue)
        {
            var calc = new SeededCalculator();

            var actualValue = Math.Round(calc.Sin(radian),3);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}