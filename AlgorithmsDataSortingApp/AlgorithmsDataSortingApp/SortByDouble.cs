using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataSortingApp
{
    class SortByDouble
    {
        void BubbleSortDoubles(double[] doubles)
        {
            double tempDouble;

            for (int write = 0; write < doubles.Length; write++)
            {
                for(int sort = 0; sort < doubles.Length - 1; sort++)
                {
                    if(doubles[sort] > doubles[sort + 1])
                    {
                        tempDouble = doubles[sort + 1];
                        doubles[sort + 1] = doubles[sort];
                        doubles[sort] = tempDouble;
                    }
                }
            }
        }

        void BucketSortDoubles()
        {

        }
    }
}
