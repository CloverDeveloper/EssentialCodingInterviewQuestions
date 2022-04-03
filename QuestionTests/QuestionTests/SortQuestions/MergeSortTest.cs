using NUnit.Framework;
using SortQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTests.SortQuestions
{
    [TestFixture]
    public class MergeSortTest
    {
        [Test]
        public void Test() 
        {
            MergeSort mergeSort = new MergeSort();

            int[] array = new int[] { 3, 5, 7, 4, 2, 1, 9, 6, 8 };

            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, mergeSort.Sort(array));
        }
    }
}
