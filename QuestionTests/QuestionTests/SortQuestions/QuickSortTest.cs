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
    public class QuickSortTest
    {
        [Test]
        public void Test() 
        {
            QuickSort quickSort = new QuickSort();

            var array = new int[] { 9, 1, 2, 7, 8, 4, 6, 5, 3 };

            Assert.AreEqual(new int[] { 1,2,3,4,5,6,7,8,9 }, quickSort.Sort(array));

            array = new int[] { 8,1,2,5,3,9,6,7,4 };

            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, quickSort.Sort(array));
        }
    }
}
