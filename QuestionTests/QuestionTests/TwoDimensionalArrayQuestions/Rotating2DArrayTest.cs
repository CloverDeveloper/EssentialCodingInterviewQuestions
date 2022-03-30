using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoDimensionalArrayQuestions;

namespace QuestionTests.TwoDimensionalArrayQuestions
{
    [TestFixture]
    public class Rotating2DArrayTest
    {
        [Test]
        public void Test() 
        {
            Rotating2DArray rotating2DArray = new Rotating2DArray();

            var array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Assert.AreEqual(
                new int[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } }, rotating2DArray.Rotating(array));

            array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Assert.AreEqual(
                new int[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } }, rotating2DArray.RotatingInPlace(array));
        }
    }
}
