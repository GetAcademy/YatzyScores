using System;
using System.Collections.Generic;
using System.Text;

namespace YatzyScores.Test
{
    class Program
    {
        void Main()
        {
            var a = new A();
            var b = new B();
            a.B = b;
            b.A = a;
        }
    }
}
