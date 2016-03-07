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
        public void TestPrimeChecker( )
        {
            Assert.False( CheckIsPrime( 1 ) );
            Assert.False( CheckIsPrime( 0 ) );
            Assert.False( CheckIsPrime( -1 ) );
            Assert.False( CheckIsPrime( -1000 ) );
            Assert.False( CheckIsPrime( -3 ) );
            Assert.True( CheckIsPrime( 2 ) );
            Assert.True( CheckIsPrime( 3 ) );
            Assert.True( CheckIsPrime( 5 ) );
            Assert.True( CheckIsPrime( 7 ) );
            Assert.True( CheckIsPrime( 7919 ) );
        }
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
