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
            
            for(int i = 0; i < 1000; i++)//replace 1000 with List.Count to do 1000000
            {
                for(int a = i + 1; a < 1000; a++)
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
        //https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-9.php
        //quick sort link

        public void doubleQuicktSorted(List<Tuple<int, Guid, double>> list, int left, int right)
        {
            if(left < right)
            {
                int pivot = Partition(list, left, right);

                if(pivot > 1)
                {
                    doubleQuicktSorted(list, left, pivot - 1);//recursion, bitch
                }
                if(pivot + 1 < right)
                {
                    doubleQuicktSorted(list, pivot + 1, right);
                }
            }
        }

        public int Partition(List<Tuple<int, Guid, double>> list, int left, int right)
        {
            var pivot = list[left].Item3;

            while (true)
            {
                while (list[left].Item3 < pivot)
                {
                    left++;
                }
                while (list[right].Item3 > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (list[left].Item3 == list[right].Item3)
                    {
                        return right;
                    }
                    Tuple<int, Guid, double> tempList = list[left];
                    list[left] = list[right];
                    list[right] = tempList;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
