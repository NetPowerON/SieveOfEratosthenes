using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber.Tests.Utility
{
    public class PrimeNumberTools
    {
        public static bool CheckIsPrime( int num )
        {
            if ( num == 2 )
            {
                return true;
            }
            if ( ( num & 1 ) == 0 )
            {
                return false;
            }
            var sqrmax = ( int )Math.Sqrt( num );
            for ( int i = 3; i <= sqrmax; ++i )
            {
                if ( num % i == 0 )
                {
                    return false;
                }
            }
            return true;
        }
    }
}
