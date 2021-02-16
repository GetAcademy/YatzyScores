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
            var f = new int[7];
            foreach (var v in _values)
            {
                f[v]++;
            }
            var p = 0;
            var s = 0;
            for (var v = 6; v > 0; v--)
            {
                if (f[v] > 1)
                {
                    p++;
                    s += v * 2;
                }
            }
            return p >= 2 ? s : 0;
        }
    }

}
