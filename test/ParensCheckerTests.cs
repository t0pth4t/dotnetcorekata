using System;
using Xunit;

namespace Tests
{
    public class ParensCheckerTests
    {
        [Theory]
        [InlineData("", true)]
        [InlineData(")", false)]
        [InlineData("(", false)]
        [InlineData("()", true)]
        [InlineData("()()", true)]
        [InlineData("(())", true)]
        [InlineData("())", false)]
        public void IsBalanced__GivenString__ReturnsIsBalanced(string s, bool expected) 
        {
            var result = ParensChecker.IsBalanced(s);
            Assert.Equal(expected, result);
        }
    }
}
