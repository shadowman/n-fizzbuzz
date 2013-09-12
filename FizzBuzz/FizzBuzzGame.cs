using System;
using System.Collections.Generic;
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
            return number.ToString();
        }

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
