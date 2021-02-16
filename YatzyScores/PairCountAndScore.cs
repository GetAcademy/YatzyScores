using System;
using System.Collections.Generic;
using System.Text;

namespace YatzyScores
{
    class PairCountAndScore
    {
        private int _pairCount;
        private int _score;

        public int TwoPairScore
        {
            get
            {
                var hasTwoPairs = _pairCount >= 2;
                return hasTwoPairs ? _score : 0;
            }
        }

        public void Add(int diceValue, int frequency)
        {
            var hasTwoOrMore = frequency > 1;
            if (!hasTwoOrMore) return;
            _pairCount++;
            _score += diceValue * 2;
        }
    }
}
