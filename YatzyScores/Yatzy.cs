using System;
using System.Collections.Generic;
using System.Text;

namespace YatzyScores
{
    public class Yatzy
    {
        private int[] _values;

        public Yatzy()
        {

        }

        public Yatzy(params int[] values)
        {
            _values = values;
        }

        public int GetTwoPairPoints()
        {
            var frequencies = new int[7];
            foreach (var value in _values)
            {
                frequencies[value]++;
            }
            var pairCount = 0;
            var score = 0;
            for (var value = 6; value > 0; value--)
            {
                if (frequencies[value] > 1)
                {
                    pairCount++;
                    score += value * 2;
                }
            }

            return pairCount >= 2 ? score : 0;
        }
    }

}
