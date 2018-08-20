using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class HeapSorting
    {
        public static List<int> SortAscending(List<int> unsortedList)
        {
            List<int> list = new List<int>(unsortedList);
            int heapSize = list.Count;

            for (int i = heapSize / 2 - 1; i >= 0; i--)
            {
                CheckMaxHeap(list, heapSize, i, true);
            }
            for (int i = heapSize - 1; i > 0; i--)
            {
                Swap(list, 0, i);
                CheckMaxHeap(list, --heapSize, 0, true);
            }
            return list;
        }
        public static List<int> SortDescending(List<int> unsortedList)
        {
            List<int> list = new List<int>(unsortedList);
            int heapSize = list.Count;

            for (int i = heapSize / 2 - 1; i >= 0; i--)
            {
                CheckMaxHeap(list, heapSize, i, false);
            }
            for (int i = heapSize - 1; i > 0; i--)
            {
                Swap(list, 0, i);
                CheckMaxHeap(list, --heapSize, 0, false);
            }
            return list;
        }
        private static void CheckMaxHeap(List<int> list, int heapSize, int parentIndex, bool sortAscending)
        {
            int maxIndex = parentIndex;
            int leftChild = parentIndex * 2 + 1;
            int rightChild = parentIndex * 2 + 2;
            if(sortAscending)
            {
                if (leftChild < heapSize && list[leftChild] > list[maxIndex])
                {
                    maxIndex = leftChild;
                }
                if (rightChild < heapSize && list[rightChild] > list[maxIndex])
                {
                    maxIndex = rightChild;
                }
            }
            else
            {
                if (leftChild < heapSize && list[leftChild] < list[maxIndex])
                {
                    maxIndex = leftChild;
                }
                if (rightChild < heapSize && list[rightChild] < list[maxIndex])
                {
                    maxIndex = rightChild;
                }
            }
            if (maxIndex != parentIndex)
            {
                Swap(list, parentIndex, maxIndex);
                CheckMaxHeap(list, heapSize, maxIndex, sortAscending);
            }
        }
        private static void Swap(List<int> list, int index1, int index2)
        {
            int temp1 = list[index1];
            int temp2 = list[index2];
            list[index1] = temp2;
            list[index2] = temp1;
        }
    }
}
