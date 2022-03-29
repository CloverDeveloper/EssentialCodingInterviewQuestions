using NUnit.Framework;
using StringQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTests.StringQuestions
{
    [TestFixture]
    public class OneAwayStringsTest
    {
        [Test]
        public void Test() 
        {
            OneAwayStrings oneAwayStrings = new OneAwayStrings();

            var strA = "abcde";
            var strB = "abde";

            Assert.AreEqual(true, oneAwayStrings.IsOneAwayStrings(strA, strB));

            strA = "abde";
            strB = "abcde";

            Assert.AreEqual(true, oneAwayStrings.IsOneAwayStrings(strA, strB));

            strA = "a";
            strB = "a";

            Assert.AreEqual(true, oneAwayStrings.IsOneAwayStrings(strA, strB));

            strA = "abcdef";
            strB = "abqdef";

            Assert.AreEqual(true, oneAwayStrings.IsOneAwayStrings(strA, strB));

            strA = "abcdef";
            strB = "abccef";

            Assert.AreEqual(true, oneAwayStrings.IsOneAwayStrings(strA, strB));

            strA = "abcdef";
            strB = "abcde";

            Assert.AreEqual(true, oneAwayStrings.IsOneAwayStrings(strA, strB));

            strA = "aaa";
            strB = "abc";

            Assert.AreEqual(false, oneAwayStrings.IsOneAwayStrings(strA, strB));

            strA = "abcde";
            strB = "abc";

            Assert.AreEqual(false, oneAwayStrings.IsOneAwayStrings(strA, strB));

            strA = "abc";
            strB = "abcde";

            Assert.AreEqual(false, oneAwayStrings.IsOneAwayStrings(strA, strB));

            strA = "abc";
            strB = "bcc";

            Assert.AreEqual(false, oneAwayStrings.IsOneAwayStrings(strA, strB));
        }
    }
}
