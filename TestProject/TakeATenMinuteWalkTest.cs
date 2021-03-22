using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeATenMinuteWalk;

namespace Tests
{
    class TakeATenMinuteWalkTest
    {
        [Test]
        public void IsValidWalk_returnTrue()
        {
            //Assert.AreEqual(new Kata().IsValidWalk(walk), true);


            Assert.AreEqual(true, new Kata().IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }));
            Assert.AreEqual(false, new Kata().IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }));
            Assert.AreEqual(false, new Kata().IsValidWalk(new string[] { "w" }));
            Assert.AreEqual(false, new Kata().IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));
        }
        /*
        [Test]
        [TestCase()]
        public void IsValidWalk_returnFalse(string[] walk)
        {
            Assert.AreEqual(new Kata().IsValidWalk(walk), false);
        }*/
    }
}
