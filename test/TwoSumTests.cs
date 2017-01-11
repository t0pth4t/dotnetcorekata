using System;
using Xunit;

namespace Tests
{
    public class TwoSumTests
    {
        [Fact]
        public void Sum__GivenTargetAndNums__WhenNoSum__ReturnsEmptyList() 
        {
            var result = TwoSum.Sum(2, new int[] {1,2});

            Assert.Empty(result);
        }

        [Theory]
        [InlineData(2, new int[]{1,1}, new int[]{0,1})]
        [InlineData(3, new int[]{1,2}, new int[]{0,1})]
        [InlineData(3, new int[]{0,1,0,2}, new int[]{1,3})]
        [InlineData(10, new int[]{0,3,0,2,4,5,6,7}, new int[]{1,7})]
        public void Sum__GivenTargetAndNums__WhenTwoNumbersSumToTarget__ReturnsIndicesOfNumbersInArray(int target, int[] nums, int[] expected) 
        {
            var result = TwoSum.Sum(target, nums);

            Assert.Equal(expected, result);
        }
    }
}
