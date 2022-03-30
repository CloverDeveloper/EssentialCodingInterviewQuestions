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
    public class AssignNumbersInMinesweeperTest
    {
        [Test]
        public void Test() 
        {
            AssignNumbersInMinesweeper assignNumbersInMinesweeper = new AssignNumbersInMinesweeper();

            var booms = new int[,] { { 0, 0 }, { 0, 1 } };

            var res = assignNumbersInMinesweeper.GetMinesweeperMap(booms,3,3);

            Assert.AreEqual(-1, res[0,0]);
            Assert.AreEqual(-1, res[0, 1]);
            Assert.AreEqual(1, res[0, 2]);
            Assert.AreEqual(2, res[1, 0]);
            Assert.AreEqual(2, res[1, 1]);
            Assert.AreEqual(1, res[1, 2]);

            booms = new int[,] { { 0, 2 }, { 2, 0 } };

            res = assignNumbersInMinesweeper.GetMinesweeperMap(booms, 3, 3);

            Assert.AreEqual(0, res[0, 0]);
            Assert.AreEqual(1, res[0, 1]);
            Assert.AreEqual(-1, res[0, 2]);
            Assert.AreEqual(1, res[1, 0]);
            Assert.AreEqual(2, res[1, 1]);
            Assert.AreEqual(1, res[1, 2]);
            Assert.AreEqual(-1, res[2, 0]);
            Assert.AreEqual(1, res[2, 1]);
            Assert.AreEqual(0, res[2, 2]);

            booms = new int[,] { { 0, 0 }, { 0, 1 }, { 1, 2 } };

            res = assignNumbersInMinesweeper.GetMinesweeperMap(booms, 3, 4);

            Assert.AreEqual(-1, res[0, 0]);
            Assert.AreEqual(-1, res[0, 1]);
            Assert.AreEqual(2, res[0, 2]);
            Assert.AreEqual(1, res[0, 3]);
            Assert.AreEqual(2, res[1, 0]);
            Assert.AreEqual(3, res[1, 1]);
            Assert.AreEqual(-1, res[1, 2]);
            Assert.AreEqual(1, res[1, 3]);
            Assert.AreEqual(0, res[2, 0]);
            Assert.AreEqual(1, res[2, 1]);
            Assert.AreEqual(1, res[2, 2]);
            Assert.AreEqual(1, res[2, 3]);

            booms = new int[,] { { 1, 1 }, { 1, 2 }, { 2, 2 }, { 4, 3 } };

            res = assignNumbersInMinesweeper.GetMinesweeperMap(booms, 5, 5);

            Assert.AreEqual(1, res[0, 0]);
            Assert.AreEqual(2, res[0, 1]);
            Assert.AreEqual(2, res[0, 2]);
            Assert.AreEqual(1, res[0, 3]);
            Assert.AreEqual(0, res[0, 4]);
            Assert.AreEqual(1, res[1, 0]);
            Assert.AreEqual(-1, res[1, 1]);
            Assert.AreEqual(-1, res[1, 2]);
            Assert.AreEqual(2, res[1, 3]);
            Assert.AreEqual(0, res[1, 4]);
            Assert.AreEqual(1, res[2, 0]);
            Assert.AreEqual(3, res[2, 1]);
            Assert.AreEqual(-1, res[2, 2]);
            Assert.AreEqual(2, res[2, 3]);
            Assert.AreEqual(0, res[2, 4]);
            Assert.AreEqual(0, res[3, 0]);
            Assert.AreEqual(1, res[3, 1]);
            Assert.AreEqual(2, res[3, 2]);
            Assert.AreEqual(2, res[3, 3]);
            Assert.AreEqual(1, res[3, 4]);
            Assert.AreEqual(0, res[4, 0]);
            Assert.AreEqual(0, res[4, 1]);
            Assert.AreEqual(1, res[4, 2]);
            Assert.AreEqual(-1, res[4, 3]);
            Assert.AreEqual(1, res[4, 4]);
        }
    }
}
