using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        #region Static Methods

        public static string TranslateNumber(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException("number");

            if (number % 15 == 0)
                return FizzBuzz;

            if (number % 3 == 0)
                return FizzBuzzGame.Fizz;

            if (number % 5 == 0)
                return FizzBuzzGame.Buzz;

            return number.ToString();
        }

        #endregion

        #region Static Fields

        public static string Fizz = "Fizz";

        public static string Buzz = "Buzz";

        public static string FizzBuzz = "FizzBuzz";

        #endregion

        #region Properties

        private int _currentNumber;

        public int CurrentNumber
        {
            get
            {
                return _currentNumber;
            }
        }

        #endregion

        #region Constructors

        public FizzBuzzGame()
        {
        }

        #endregion

        #region Methods

        public virtual string GetNext()
        {
            return FizzBuzzGame.TranslateNumber(++_currentNumber);
        }

        #endregion
    }
}
