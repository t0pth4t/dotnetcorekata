using System;
using Xunit;

namespace Tests
{
    public class TomStringTests
    {
        [Theory]
        [InlineData(new string[0], 0)]
        [InlineData(new []{"a"}, 0)]
        [InlineData(new []{"a", "a"}, 0)]
        [InlineData(new []{"aa"}, 1)]
        [InlineData(new []{"b"}, 1)]
        [InlineData(new []{"c"}, 2)]
        [InlineData(new []{"aA1", "b"}, 132)]
        [InlineData(new []{"aa", "BB", "cc", "DD"}, 640)]
        public void Hash__GivenArrayOfStrings__ReturnsHash(string[] input, int expected) 
        {
            var result = TomString.Hash(input);

            Assert.Equal(expected, result);
        }
    }
}
