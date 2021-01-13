using System;
using NUnit.Framework;
using SG.Calculator.BLL;

namespace SG.Calculator.Tests
{
    [TestFixture]
    public class SimpleMathTests
    {
        [Test]
        public void IntegerDivision1()
        {
            SimpleMath math = new SimpleMath();
            int result = math.Divide(5, 2);

            Assert.AreEqual(2, result);
        }

        //[TestCase(4, 2, 2)]
        //[TestCase(13, 6, 2)]
        //[TestCase(-20, 5, -4)]
        //public void IntegerDivision(int x, int y, int expected)
        //{
        //    SimpleMath math = new SimpleMath();
        //    int actual = math.Divide(x, y);

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void DivideByZeroTest()
        //{
        //    SimpleMath math = new SimpleMath();
        //    Assert.Throws<DivideByZeroException>(() => math.Divide(5, 0));
        //}
    }
}
