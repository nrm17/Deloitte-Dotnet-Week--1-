﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2NewFeatures
{
    class SwapExample <T>
    {
        public void Swap( ref T a , ref T b ) // ref is used for call by reference because pointers arent supported by C#
        {
            T temp = a;
            a = b;
            b = temp;

        }
    }
}
