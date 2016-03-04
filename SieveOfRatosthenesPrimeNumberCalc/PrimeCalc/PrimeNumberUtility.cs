using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCalc
{
    public class PrimeNumberUtility
    {
        private     int                         _rootPrimeExtra;
        private     PrimeNumberSieve            _sieve                      = null;
        private     bool                        _sieveInitialized           = false;

        internal PrimeNumberSieve Seive
        {
            get
            {
                return _sieve;
            }
        }

        public int MaxSearchNumber
        {
            get
            {
                return _sieve.MaxSearchNumber;
            }
        }

        public PrimeNumberUtility( int maxPrime = 100000000 ) // 100 Million
        {
            _rootPrimeExtra = ( int )Math.Sqrt( maxPrime );
            _sieve = new PrimeNumberSieve( maxPrime );
        }

        public int CountPrimes( )
        {
            for ( int i = 3; i <= _rootPrimeExtra; i += 2 )
            {
                CalculatePrimeOptimized( i );
            }
            return _sieve.GetPrimeCount( );
        }

        public IEnumerable< int > EnumeratePrimeNumberList( )
        {
            var _start = 3;
            if ( _sieveInitialized == false )
            {
                for( int i = 3; i <= _rootPrimeExtra; i += 2 )
                {
                    if ( CalculatePrimeOptimized( i ) )
                    {
                        yield return i;
                    }
                }
                _start = _rootPrimeExtra;
            }
            foreach ( var num in EnumeratePrimeFrom( 3 ) )
            {
                yield return num;
            }
        }

        private IEnumerable< int > EnumeratePrimeFrom( int start )
        {
            if ( ( start & 1 ) == 0 )
            {
                ++start;
            }
            for ( int i = start; i < _sieve.MaxSearchNumber; i += 2 )
            {
                if ( _sieve.ValArray[ i ] == false )
                {
                    yield return i;
                }
            }
        }

        private bool CalculatePrimeOptimized( int number )
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
            _sieveInitialized = true;
            _sieve.ClearMultiplier( number );
            return true;
        }
    }
}
