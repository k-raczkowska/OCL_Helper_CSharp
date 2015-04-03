using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCL_Helper.types
{
    class Integer
    {
        int value;

        Integer(int x)
        {
            value = x;
        }

        public Integer operator <(Integer i1, Integer i2)
        {
            return i1.value < i2.value ? i1 : i2;
        }

        public Integer operator >(Integer i1, Integer i2)
        {
            return i1.value > i2.value ? i1 : i2;
        }
    }
}
