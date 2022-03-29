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
    public class BubbleSortTest
    {
        [Test]
        public void Sort() 
        {
            BubbleSort bubbleSort = new BubbleSort();

            var unSortedArray = new int[] { 9,8,1,2,4,3,6,5,7};
            Assert.AreEqual(new int[] { 1,2,3,4,5,6,7,8,9}, bubbleSort.Sort(unSortedArray));

            unSortedArray = new int[] { 7, 8, 2, 1, 6, 3, 4, 5, 9 };
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, bubbleSort.Sort(unSortedArray));
        }
    }
}
