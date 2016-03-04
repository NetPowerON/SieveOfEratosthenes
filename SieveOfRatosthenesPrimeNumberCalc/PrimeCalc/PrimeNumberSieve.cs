using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCalc
{
    internal class PrimeNumberSieve
    {
        private     bool[ ]                     _valArray                   = null;
        private     int                         _maxSize                    = -1;

        internal bool[ ] ValArray
        {
            get
            {
                return _valArray;
            }
        }

        public int MaxSearchNumber
        {
            get
            {
                return _maxSize;
            }
        }

        internal PrimeNumberSieve( int maxNumberSize )
        {
            _valArray = new bool[ maxNumberSize + 1 ];
            // Internally true means not prime.
            _valArray[ 0 ] = true;
            _valArray[ 1 ] = true;

            for ( int counter = 4; counter <= maxNumberSize; counter += 2 )
            {
                _valArray[ counter ] = true;
            }

            _maxSize = maxNumberSize;
        }

        internal void ClearMultiplier( int multiplier )
        {
            for ( int counter = multiplier * 2; counter < _maxSize; counter += multiplier )
            {
                _valArray[ counter ] = true;
            }
        }

        internal bool CheckPrime( int number )
        {
            return !_valArray[ number ];
        }

        public int GetPrimeCount( )
        {
            return _valArray.Count( bv => !bv );
        }
    }
}
