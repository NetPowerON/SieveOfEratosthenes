using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrimeNumber.Tests
{
    using PrimeCalc;
    using static Utility.PrimeNumberTools;

    public class PrimeNumberUtilityTest
    {
        [Fact]
        public void CheckPrimes1000( )
        {
            var primeUtil = new PrimeNumberUtility( 1000 );
            foreach( var primeNumber in primeUtil.EnumeratePrimeNumberList( ) )
            {
                Assert.True( CheckIsPrime( primeNumber ) );
            }
        }

        [Fact]
        public void CheckPrimes10( )
        {
            var primeUtil = new PrimeNumberUtility( 10 );
            foreach ( var primeNumber in primeUtil.EnumeratePrimeNumberList( ) )
            {
                Assert.True( CheckIsPrime( primeNumber ) );
            }
        }

        [Fact]
        public void CheckPrimes( )
        {
            var primeUtil = new PrimeNumberUtility( );
            foreach ( var primeNumber in primeUtil.EnumeratePrimeNumberList( ) )
            {
                Assert.True( CheckIsPrime( primeNumber ) );
            }
        }
    }
}
