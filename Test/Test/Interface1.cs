using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    interface Interface1
    {
        string Method1();
        string Method2();
        int this[int index] {
            get;
            set;
        }
    }
}
