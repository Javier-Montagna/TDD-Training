using System;

namespace BowlingScore.Models
{
    public class Game
    {
        private int[] _rolls = new int[21];

        private int currentRoll = 0;

        public void roll(int pins)
        {
            this._rolls[currentRoll] = pins;
            currentRoll++;
        }

        public int scoreGame()
        {
            int score = 0;
            int frameIndex = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (this.isStrike(frameIndex))
                {
                    score += 10 + strikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (this.isSpare(frameIndex))
                {
                    score += 10 + _rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                    frameIndex += 2;
                }        
            }
            return score;
        }

        private bool isSpare(int frameIndex)
        {
            return (_rolls[frameIndex] + _rolls[frameIndex + 1] == 10);
        }

        private bool isStrike(int frameIndex)
        {
            return (_rolls[frameIndex] == 10);
        }

        public int strikeBonus(int frameIndex)
        {
            return (_rolls[frameIndex + 1] + _rolls[frameIndex + 2]);
        }
    }
}
