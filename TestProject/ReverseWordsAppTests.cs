using NUnit.Framework;
using ReverseWords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class ReverseWordsAppTests
    {
        [Test]
        [TestCase("This is an example!", "sihT si na !elpmaxe")]
        [TestCase("double  spaces", "elbuod  secaps")]
        [TestCase(" example ", " elpmaxe ")]
        public void ReverseWords_ShouldReturnTrue(string str, string expectedResult)
        {
            var result = new ReverseWordsApp().ReverseWords(str);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
