using NUnit.Framework;
using ReverseArray;

namespace Test
{
    public class ReverseArrayAppTest
    {
        [Test]
        [TestCase(123, new long[] { 3, 2, 1 })]
        [TestCase(35231, new long[] { 1, 3, 2, 5, 3 })]
        [TestCase(23582357, new long[] { 7, 5, 3, 2, 8, 5, 3, 2 })]
        [TestCase(984764738, new long[] { 8, 3, 7, 4, 6, 7, 4, 8, 9 })]
        [TestCase(45762893920, new long[] { 0, 2, 9, 3, 9, 8, 2, 6, 7, 5, 4 })]
        [TestCase(548702838394, new long[] { 4, 9, 3, 8, 3, 8, 2, 0, 7, 8, 4, 5 })]
        public void ConvertNumberToReversedArray_ShouldReturnTrue(long number, long[] expectedResult )
        {
            var result = new App().ConvertNumberToReversedArray(number);
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [TestCase(123, new long[] { 1, 2, 3 })]
        public void ConvertNumberToReversedArray_ShouldReturnFalse(long number, long[] expectedResult)
        {
            var result = new App().ConvertNumberToReversedArray(number);
            Assert.AreNotEqual(result, expectedResult);
        }
    }
}