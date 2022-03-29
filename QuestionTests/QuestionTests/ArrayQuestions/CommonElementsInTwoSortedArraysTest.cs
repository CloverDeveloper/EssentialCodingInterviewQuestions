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
    public class CommonElementsInTwoSortedArraysTest
    {
        [Test]
        public void GetCommonArrays() 
        {
            CommonElementsInTwoSortedArrays commonElementsInTwoSortedArrays = 
                new CommonElementsInTwoSortedArrays();

            var arrayA = new int[] { 1,3,4,6,7,9 };

            var arrayB = new int[] { 1,2,4,5,9,10 };

            Assert.AreEqual(new int[] { 1,4,9}, commonElementsInTwoSortedArrays.GetCommonArray(arrayA, arrayB));

            arrayA = new int[] { 1, 3, 4, 5, 7, 9 };

            arrayB = new int[] { 1, 2, 4, 5, 9, 10 };

            Assert.AreEqual(new int[] { 1, 4, 5, 9 }, 
                commonElementsInTwoSortedArrays.GetCommonArray(arrayA, arrayB));
        }
    }
}
