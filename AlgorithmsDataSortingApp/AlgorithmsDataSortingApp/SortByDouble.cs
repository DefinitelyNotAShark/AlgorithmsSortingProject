using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataSortingApp
{
    class SortByDouble
    {

        public List<Tuple<int, Guid, double>> doubleBubbleSorted(List<Tuple<int, Guid, double>> list)//takes in the unsorted list and returns the sorted list
        {
            Tuple<int, Guid, double> tempList;
            
            for(int i = 0; i < list.Count; i++)
            {
                for(int a = i + 1; a < list.Count; a++)
                {
                    if(list[i].Item3 > list[a].Item3)//item 3 refers to the 3rd object in the tuple
                    {
                        tempList = list[i];
                        list[i] = list[a];
                        list[a] = tempList;
                    }
                }
            }
            return list;
        }

        void doubleBucketSorted(List<Tuple<int, Guid, double>> list)
        {

        }
    }
}
