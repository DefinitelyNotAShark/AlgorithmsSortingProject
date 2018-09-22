using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataSortingApp
{
    class SortByGuid
    {
        public List<Tuple<int, Guid, double>> guidBubbleSorted(List<Tuple<int, Guid, double>> list)//takes in the unsorted list and returns the sorted list
        {
            Tuple<int, Guid, double> tempList;

            for (int i = 0; i < list.Count; i++)
            {
                for (int a = i + 1; a < list.Count; a++)
                {
                    // if (list[i].Item2 > list[a].Item2)//convert to number
                    //{
                    //    tempList = list[i];
                    //    list[i] = list[a];
                    //    list[a] = tempList;
                    //}
                }
            }
            return list;
        }

        void guidBucketSorted(List<Tuple<int, Guid, double>> list)
        {

        }


    }
}
