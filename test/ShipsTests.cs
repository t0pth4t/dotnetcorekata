using System;
using Xunit;

namespace Tests
{
    public class ShipsTests
    {
        [Fact]
        public void CountShips__GivenEmptyBoard__ReturnsZero()
        {
            var board = new char[,]{
                {'.','.','.','.'},
                {'.','.','.','.'},
                {'.','.','.','.'},
                {'.','.','.','.'},
            };

            var result = Ships.CountShips(board);

            Assert.Equal(0, result);
        }

        [Fact]
        public void CountShips__GivenBoardWithOneLengthOneShip__ReturnsOne()
        {
            var board = new char[,]{
                {'.','.','.','.'},
                {'.','.','.','.'},
                {'.','.','X','.'},
                {'.','.','.','.'},
            };

            var result = Ships.CountShips(board);

            Assert.Equal(1, result);
        }

        [Fact]
        public void CountShips__GivenBoardWithOneLengthTwoShip__ReturnsOne()
        {
            var board = new char[,]{
                {'.','.','.','.'},
                {'.','.','.','.'},
                {'.','.','X','.'},
                {'.','.','X','.'},
                {'.','.','.','.'},
            };

            var result = Ships.CountShips(board);

            Assert.Equal(1, result);
        }

        [Fact]
        public void CountShips__GivenBoardWithTwoLengthOneShips__ReturnsTwo()
        {
            var board = new char[,]{
                {'.','.','.','.'},
                {'X','.','.','.'},
                {'.','.','.','.'},
                {'.','.','X','.'},
                {'.','.','.','.'},
            };

            var result = Ships.CountShips(board);

            Assert.Equal(2, result);
        }

        [Fact]
        public void CountShips__GivenBoardWithTwoLengthTwoShips__ReturnsTwo()
        {
            var board = new char[,]{
                {'.','.','.','.'},
                {'X','.','.','.'},
                {'X','.','X','.'},
                {'.','.','X','.'},
                {'.','.','.','.'},
            };

            var result = Ships.CountShips(board);

            Assert.Equal(2, result);
        }

                [Fact]
        public void CountShips__GivenBoardWithTwoLengthTwoShip__ReturnsTwo()
        {
            var board = new char[,]{
                {'.','.','X','.'},
                {'X','.','X','.'},
                {'X','.','X','.'},
                {'.','.','X','.'},
                {'.','.','.','.'},
            };

            var result = Ships.CountShips(board);

            Assert.Equal(2, result);
        }
    }
}