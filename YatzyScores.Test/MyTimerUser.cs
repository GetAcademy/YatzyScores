using System;
using System.Collections.Generic;
using System.Text;

namespace YatzyScores.Test
{
    class MyTimerUser : ITimerUser
    {
        public void Finished()
        {
            
        }

        void Start()
        {
            var timer = new Timer(this);
        }
    }
}
