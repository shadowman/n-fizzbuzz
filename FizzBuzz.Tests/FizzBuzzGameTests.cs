using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzGameTests
    {
        [TestMethod]
        public void GetCurrentNumberAfterCreateWithEmptyConstructorReturns0()
        {
            var game = new FizzBuzzGame();

            Assert.AreEqual(game.CurrentNumber, 0);
        }

        [TestMethod]
        public void GetNextIncreasesCurrentNumberIn1()
        {
            var game = new FizzBuzzGame();

            for (int i = 0; i < 100; i++)
            {
                var currentNumber = game.CurrentNumber;
                
                game.GetNext();

                Assert.AreEqual(game.CurrentNumber, currentNumber + 1);
            }
        }
    }
}
