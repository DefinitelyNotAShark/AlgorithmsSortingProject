using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataSortingApp
{
    class SortByID
    {
        public List<Tuple<int, Guid, double>> IDBubbleSorted(List<Tuple<int, Guid, double>> list)//takes in the unsorted list and returns the sorted list
        {
            Tuple<int, Guid, double> tempList;

            for (int i = 0; i < list.Count; i++)
            {
                for (int a = i + 1; a < list.Count; a++)
                {
                    if (list[i].Item1 > list[a].Item1)//item 3 refers to the 3rd object in the tuple
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

        public void IDQuickSorted(List<Tuple<int, Guid, double>> list, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(list, left, right);

                if (pivot > 1)
                {
                    IDQuickSorted(list, left, pivot - 1);//recursion, bitch
                }
                if (pivot + 1 < right)
                {
                    IDQuickSorted(list, pivot + 1, right);
                }
            }
        }

        public int Partition(List<Tuple<int, Guid, double>> list, int left, int right)
        {
            var pivot = list[left].Item1;

            while (true)
            {
                while (list[left].Item1 < pivot)
                {
                    left++;
                }
                while (list[right].Item1 > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (list[left].Item1 == list[right].Item1)
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
