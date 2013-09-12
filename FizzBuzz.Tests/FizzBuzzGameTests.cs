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

        [TestMethod]
        public void GetNextReturnsTheNumberIfTheNextNumberInTheSequenceIsNotDivisibleBy5Or3()
        {
            var game = new FizzBuzzGame();

            for (int i = 0; i < 100; i++)
            {
                var currentNumber = game.CurrentNumber;
                var nextNumber = currentNumber + 1;
                var response = game.GetNext();

                if (nextNumber % 3 != 0 && nextNumber % 5 != 0)
                {
                    Assert.AreEqual(response, nextNumber.ToString());
                }
            }
        }

        [TestMethod]
        public void GetNextReturnsFizzIfTheNextNumberInTheSequenceIsDivisibleBy3ButNot15()
        {
            var game = new FizzBuzzGame();

            for (int i = 0; i < 100; i++)
            {
                var currentNumber = game.CurrentNumber;
                var nextNumber = currentNumber + 1;
                var response = game.GetNext();

                if (nextNumber % 3 == 0 && nextNumber % 15 != 0)
                {
                    Assert.AreEqual(response, FizzBuzzGame.Fizz);
                }
            }
        }
    }
}
