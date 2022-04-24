using FluentAssertions;
using Game;
using System;
using Xunit;

namespace GameTest
{
    public class GameTest
    {
        private readonly GameLogics _sut;

        public GameTest()
        {
            _sut = new GameLogics();
        }

        [Fact]
        public void NumberDevidedBy3()
        {
            int Number = 9;
            var expected = _sut.CheckNumber(Number);

            expected.Should().Be("fizz");
        }

        [Fact]
        public void NumberDevidedBy5()
        {
            int Number = 10;
            var expected = _sut.CheckNumber(Number);

            expected.Should().Be("buzz");
        }

        [Fact]
        public void NumberDevidedBy15()
        {
            int Number = 30;
            var expected = _sut.CheckNumber(Number);

            expected.Should().Be("fizzbuzz");
        }

    }
}
