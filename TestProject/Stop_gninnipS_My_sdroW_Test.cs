using NUnit.Framework;
using Stop_gninnipS_My_sdroW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Stop_gninnipS_My_sdroW_Test
    {
        [Test]
        public void IsStringMoreThen5wordSymbolsReversed()
        {
            Assert.AreEqual("emocleW", new Kata().SpinWords("Welcome"));
            Assert.AreEqual("Hey wollef sroirraw", new Kata().SpinWords("Hey fellow warriors"));
            Assert.AreEqual("This is a test", new Kata().SpinWords("This is a test"));
            Assert.AreEqual("This is rehtona test", new Kata().SpinWords("This is another test"));
            Assert.AreEqual("You are tsomla to the last test", new Kata().SpinWords("You are almost to the last test"));
            Assert.AreEqual("Just gniddik ereht is llits one more", new Kata().SpinWords("Just kidding there is still one more"));
        }
    }
}
