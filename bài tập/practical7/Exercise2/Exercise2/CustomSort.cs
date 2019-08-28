using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class CustomSort : IComparer
    {
        public int Compare(object x, object y)
        {
            IMovie movie1 = x as IMovie;
            Movie movie2 = y as Movie;
            if (movie1 == null || movie2 == null)
            {
                throw new InvalidOperationException();
            }

            if (movie1.AverageRate < movie2.AverageRate)
            {
                return 1;
            }
            else if (movie1.AverageRate == movie2.AverageRate)
            {
                return 0;
            }
            else
                return -1;

        }
    }
}
