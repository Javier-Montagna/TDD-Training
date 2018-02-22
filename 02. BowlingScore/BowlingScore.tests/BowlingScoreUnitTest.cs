using System;
using Xunit;
using BowlingScore.Models;
using Moq;

namespace BowlingScore.Tests
{
    public class BowlingScoreUnitTest
    {
        private Game g;

        public BowlingScoreUnitTest()
        {
            this.g = new Game();
        }

        [Fact]
        public void DoesGameExist()
        {
            Assert.NotNull(g);
        }

        [Fact]
        public void GutterGameReturns0()
        {
            this.rollMany(20, 0);
            Assert.Equal(0, g.scoreGame());
        }

        [Fact]
        public void SinglePinGameReturns20()
        {
            this.rollMany(20, 1);
            Assert.Equal(20, g.scoreGame());
        }

        [Fact]
        public void OneSpareReturnsAppropiateValue()
        {
            g.roll(5);
            g.roll(5);
            //Spare
            g.roll(3);

            rollMany(17, 0);
            Assert.Equal(16, g.scoreGame());

        }

        [Fact]
        public void OneStrikeReturnsAppropiateValue()
        {
            g.roll(10);//Strike
            g.roll(3);
            g.roll(4);

            rollMany(16, 0);
            Assert.Equal(24, g.scoreGame());
        }

        [Fact]
        public void PerfectGameReturns300()
        {
            rollMany(12,10);
            Assert.Equal(300, g.scoreGame());
        }

        private void rollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                g.roll(pins);
            }
        }
    }
}
