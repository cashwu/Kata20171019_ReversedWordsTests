using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20171019_ReversedWordsTests
{
    [TestClass]
    public class ReversedWordsTests
    {
        [TestMethod]
        public void input_apple()
        {
            AssertReversedWordsShouldBe("apple", "apple");
        }

        [TestMethod]
        public void input_apple_mac()
        {
            AssertReversedWordsShouldBe("mac apple", "apple mac");
        }

        private void AssertReversedWordsShouldBe(string expected, string words)
        {
            var kata = new Kata();
            var result = kata.ReverseWords(words);
            Assert.AreEqual(expected, result);
        }
    }

    public class Kata
    {
        public string ReverseWords(string str)
        {
            return string.Join(" ", str.Split(' ').Reverse());
        }
    }
}
