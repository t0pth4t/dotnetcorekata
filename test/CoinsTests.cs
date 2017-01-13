using System;
using Xunit;
using System.Collections.Generic;

namespace Tests
{
    public class CoinsTests
    {
        [Theory]
        [InlineData(0, new int[0])]
        [InlineData(1, new int[]{1})]
        [InlineData(2, new int[]{1,1})]
        [InlineData(5, new int[]{5})]
        [InlineData(6, new int[]{5, 1})]
        [InlineData(16, new int[]{10, 5, 1})]
        [InlineData(20, new int[]{10, 10})]
        [InlineData(25, new int[]{25})]
        [InlineData(99, new int[]{25, 25, 25, 10, 10, 1, 1, 1, 1})]
        public void Change__ReturnsCorrectAmountOfCoins(int amount, IEnumerable<int> expected) 
        {
            var result = Coins.Change(amount);

            Assert.Equal(expected, result);
        }
    }
}
