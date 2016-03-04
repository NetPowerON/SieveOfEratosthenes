using PrimeCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfRatosthenesPrimeNumberCalc
{
    class Program
    {
        private const int                       HIGHPRIME               = 1000;

        private static  PrimeNumberUtility      _primeUtil              = new PrimeNumberUtility( HIGHPRIME );

        static void Main( string[ ] args )
        {
            Console.WriteLine( $"Calculating PrimeNumber Count upto {_primeUtil.MaxSearchNumber}..." );
            CountPrimeNumbers( );

            Console.WriteLine( "Press Enter..." );
            Console.ReadLine( );

            Console.WriteLine( $"Displaying PrimeNumber Count upto {_primeUtil.MaxSearchNumber}..." );

            DisplayPrimeNumbers( );

            Console.WriteLine( "Press Enter..." );
            Console.ReadLine( );
        }

        private static void DisplayPrimeNumbers( )
        {
            foreach( var prime in _primeUtil.EnumeratePrimeNumberList( ) )
            {
                Console.WriteLine( $"{prime}" );
            }
        }

        private static void CountPrimeNumbers( )
        {
            var count = _primeUtil.CountPrimes( );
            Console.WriteLine( $"Number of Prime Numbers from 1 to {_primeUtil.MaxSearchNumber} is {count}" );
        }
    }
}
