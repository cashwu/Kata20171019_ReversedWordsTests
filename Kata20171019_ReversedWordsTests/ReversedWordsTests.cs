using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20171019_ReversedWordsTests
{
    [TestClass]
    public class ReversedWordsTests
    {
        [TestMethod]
        public void input_apple()
        {
            var kata = new Kata();
            var result = kata.ReverseWords("apple");
            Assert.AreEqual("apple", result);
        }
    }

    public class Kata
    {
        public string ReverseWords(string str)
        {
            return str;
        }
    }
}
