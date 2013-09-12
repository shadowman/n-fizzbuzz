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
            throw new NotImplementedException();
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
            ++_currentNumber;

            return string.Empty;
        }

        #endregion
    }
}
