using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class SmallApartment : House
    {
        public SmallApartment() : base(50)
        {
        }
        public override string ShowData()
        {
            return $"I am an apartment, my area is {Area} m2";
        }
    }
}
