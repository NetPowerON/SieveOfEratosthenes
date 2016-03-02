using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCalc
{
    public class PrimeNumberUtility
    {
        private     int                         _maxPrime;
        private     int                         _rootPrimeExtra;
        private     PrimeNumberSieve            _seive                      = null;

        internal PrimeNumberSieve Seive
        {
            get
            {
                return _seive;
            }
        }

        public PrimeNumberUtility( int maxPrime = 100000000 ) // 1 Million
        {
            _maxPrime = maxPrime;
            _rootPrimeExtra = ( int )Math.Sqrt( maxPrime );
            _seive = new PrimeNumberSieve( maxPrime );
        }

        public int CountPrimes( )
        {
            for ( int i = 3; i <= _rootPrimeExtra; i += 2 )
            {
                CalculatePrimeOptimized( i );
            }
            return _seive.GetPrimeCount( );
        }

        public bool CalculatePrimeOptimized( int number )
        {
            var maxCount =
                number == 3
                    ? 1
                    : number == 5
                        ? 1
                        : ( int )Math.Sqrt( number );

            for ( int i = 3; i <= maxCount; ++i )
            {
                if ( number % i == 0 )
                {
                    return false;
                }
            }
            _seive.ClearMultiplier( number );
            return true;
        }
    }
}
