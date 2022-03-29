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
    public class IsOneArrayARotationOfAnotherTest
    {
        [Test]
        public void Test() 
        {
            IsOneArrayARotationOfAnother isOneArrayARotationOfAnother = new IsOneArrayARotationOfAnother();

            var arrayA = new int[] { 1, 2, 3, 4, 5, 6, 7};

            var arrayB = new int[] { 4, 5, 6, 7, 1, 2, 3};

            Assert.AreEqual(true, isOneArrayARotationOfAnother.IsRotation(arrayA,arrayB));

            arrayA = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            arrayB = new int[] { 4, 5, 6, 9, 1, 2, 3 };

            Assert.AreEqual(false, isOneArrayARotationOfAnother.IsRotation(arrayA, arrayB));

            arrayA = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            arrayB = new int[] { 4, 5, 6, 1, 2, 3 };

            Assert.AreEqual(false, isOneArrayARotationOfAnother.IsRotation(arrayA, arrayB));
        }
    }
}
