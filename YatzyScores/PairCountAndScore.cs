using System;
using System.Collections.Generic;
using System.Text;

namespace YatzyScores
{
    class PairCountAndScore
    {
        public int PairCount;
        public int Score;

        public int TwoPairScore
        {
            get
            {
                var hasTwoPairs = PairCount >= 2;
                return hasTwoPairs ? Score : 0;
            }
        }

        public void Add(int diceValue, int frequency)
        {
            var hasTwoOrMore = frequency > 1;
            if (!hasTwoOrMore) return;
            PairCount++;
            Score += diceValue * 2;
        }
    }
}
