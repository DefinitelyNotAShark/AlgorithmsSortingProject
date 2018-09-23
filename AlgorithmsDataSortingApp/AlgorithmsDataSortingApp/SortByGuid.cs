using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataSortingApp
{
    class SortByGuid
    {
        public List<Tuple<int, Guid, double>> GuidBubbleSorted(List<Tuple<int, Guid, double>> list)//takes in the unsorted list and returns the sorted list
        {
            Tuple<int, Guid, double> tempList;

            for (int i = 0; i < list.Count; i++)
            {
                for (int a = i + 1; a < list.Count; a++)
                {
                    if (GuidToDouble(list[i].Item2) > GuidToDouble(list[a].Item2))//item 2 refers to the 3rd object in the tuple
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

        public void GuidQuickSorted(List<Tuple<int, Guid, double>> list, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(list, left, right);

                if (pivot > 1)
                {
                    GuidQuickSorted(list, left, pivot - 1);//recursion, bitch
                }
                if (pivot + 1 < right)
                {
                    GuidQuickSorted(list, pivot + 1, right);
                }
            }
        }

        public int Partition(List<Tuple<int, Guid, double>> list, int left, int right)
        {
            var pivot = GuidToDouble(list[left].Item2);

            while (true)
            {
                while (GuidToDouble(list[left].Item2) < pivot)
                {
                    left++;
                }
                while (GuidToDouble(list[right].Item2) > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (GuidToDouble(list[left].Item2) == GuidToDouble(list[right].Item2))
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

        public double GuidToDouble(Guid inputGuid) //This method converts a guid into a byte array, and then converts the bytearray into a double
        {
            double doubleSolution = BitConverter.ToDouble(inputGuid.ToByteArray(), 0);
            return doubleSolution;
        }


    }
}
