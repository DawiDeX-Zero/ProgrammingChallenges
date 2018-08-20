using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class QuickSort
    {
        public static List<int> SortAscending(List<int> unsortedList)
        {
            List<int> list = new List<int>(unsortedList);
            Quick(list, 0, list.Count - 1, true);
            return list;
        }
        public static List<int> SortDescending(List<int> unsortedList)
        {
            List<int> list = new List<int>(unsortedList);
            Quick(list, 0, list.Count - 1, false);
            return list;
        }
        private static void Quick(List<int> list, int left, int right, bool sortAscending)
        {
            int i = left;
            int j = right;
            int pivot = ChoosePivot(list, left, right);

            while (i <= j)
            {
                if(sortAscending)
                {
                    while (list[i] < pivot)
                    {
                        i++;
                    }
                    while (list[j] > pivot)
                    {
                        j--;
                    }
                }
                else
                {
                    while (list[i] > pivot)
                    {
                        i++;
                    }
                    while (list[j] < pivot)
                    {
                        j--;
                    }
                }
                if (i <= j)
                {
                    Swap(list, i, j);
                    i++;
                    j--;
                }
            }
            if(left<j)
            {
                if (sortAscending)
                    Quick(list, left, j, true);

                else
                    Quick(list, left, j, false);
            }
            if(i<right)
            {
                if(sortAscending)
                    Quick(list, i, right, true);
                else
                    Quick(list, i, right, false);
            }
        }
        private static void Swap(List<int> list, int index1, int index2)
        {
            int temp1 = list[index1];
            int temp2 = list[index2];
            list[index1] = temp2;
            list[index2] = temp1;
        }
        private static int ChoosePivot(List<int> list, int left, int right)
        {
            int[] arr = { list[0], list[(left + right) / 2], list[list.Count - 1] };
            Array.Sort(arr);
            return arr[1];

        }

    }

}
