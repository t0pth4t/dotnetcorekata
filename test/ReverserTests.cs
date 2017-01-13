using System;
using Xunit;

namespace Tests
{
    public class ReverserTests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("a", "a")]
        [InlineData("hello", "olleh")]
        public void Reverse__GivenString__ReturnsReversedString(string s, string expected) 
        {
            var result = Reverser.Reverse(s);

            Assert.Equal(expected, result);
        }
    }
}
