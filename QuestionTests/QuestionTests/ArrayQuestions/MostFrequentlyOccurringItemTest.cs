using ArrayQuestions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTests.ArrayQuestions
{
    [TestFixture]
    public class MostFrequentlyOccurringItemTest
    {
        [Test]
        public void Test()
        {
            MostFrequentlyOccurringItem mostFrequentlyOccurringItem = new MostFrequentlyOccurringItem();

            int[] array = null;
            Assert.AreEqual(null, mostFrequentlyOccurringItem.GetFrequentlyOccurringItem(array));

            array = new int[] { 1, 3, 1, 3, 2, 1 };
            Assert.AreEqual(1, mostFrequentlyOccurringItem.GetFrequentlyOccurringItem(array));

            array = new int[] { 3, 3, 1, 3, 2, 1 };
            Assert.AreEqual(3, mostFrequentlyOccurringItem.GetFrequentlyOccurringItem(array));

            array = new int[] { 2, 2, 29, 3, 2, 1 };
            Assert.AreEqual(2, mostFrequentlyOccurringItem.GetFrequentlyOccurringItem(array));

            array = new int[] { 2, 2, 29, 30, 2, 1 };
            Assert.AreEqual(2, mostFrequentlyOccurringItem.GetFrequentlyOccurringItem(array));
        }
    }
}
