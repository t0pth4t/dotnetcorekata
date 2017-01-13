using System;
using Xunit;

namespace Tests
{
    public class LargestDiffTests
    {
        [Theory]
        [InlineData(new int[]{1}, 0)]
        [InlineData(new int[]{1, 1}, 0)]
        [InlineData(new int[]{1, 2}, 1)]
        [InlineData(new int[]{8, 3, 5, 10}, 7)]
        [InlineData(new int[]{8, 10, 5, 10, 1, 4}, 9)]
        public void Diff__FindsLargestDiff(int[] data, int expected) 
        {
            var result = LargestDiff.Diff(data);
            Assert.Equal(expected, result);
        }
    }
}
