using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace YatzyScores
{
    public class Timer
    {
        private ITimerUser _timerUser;

        public Timer(ITimerUser timerUser)
        {
            _timerUser = timerUser;
        }

        void X()
        {
            _timerUser.Finished();
        }
        
    }
}
