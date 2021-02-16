using System;
using System.Collections.Generic;
using System.Text;

namespace YatzyScores
{
    public class Yatzy
    {
        private int[] _values;

        public Yatzy(params int[] values)
        {
            _values = values;
        }

        /*
         * 1: Introdusere variabel
         * 2: Introdusere metode
         * 3: Introdusere klasse

            public int GetTwoPairPoints()
            {
                var frequencies = new int[7];
                foreach (var value in _values)
                {
                    frequencies[value]++;
                }
                var points = 0;
                var score = 0;
                for (var diceValue = 6; diceValue > 0; diceValue--)
                {
                    var hasTwoOrMore = frequencies[diceValue] > 1;
                    if (hasTwoOrMore)
                    {
                        points++;
                        score += diceValue * 2;
                    }
                }
                return points >= 2 ? score : 0;
            }         
         */

        public int GetTwoPairPoints()
        {
            var frequencies = CreateFrequencies(_values);
            var score = CalcPairCountAndScore(frequencies);
            return score.TwoPairScore;
        }

        private static PairCountAndScore CalcPairCountAndScore(int[] frequencies)
        {
            var score = new PairCountAndScore();
            for (var diceValue = 6; diceValue > 0; diceValue--)
            {
                score.Add(diceValue, frequencies[diceValue]);
            }
            return score;
        }

        private static int[] CreateFrequencies(int[] values)
        {
            var frequencies = new int[7];
            foreach (var value in values)
            {
                frequencies[value]++;
            }
            return frequencies;
        }
    }
}
