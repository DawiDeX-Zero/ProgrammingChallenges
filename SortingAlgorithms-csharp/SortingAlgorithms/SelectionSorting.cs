using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class SelectionSorting
    {
        public static List<int> SortAscending(List<int> unsortedList)
        {
            List<int> list = new List<int>(unsortedList);
            int minIndex = 0;
            int processedElements = 0;
            int temp1;
            int temp2;
            while(processedElements!=list.Count)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == 0)
                        i += processedElements;
                    if (list[minIndex] > list[i])
                        minIndex = i;
                }
                temp1 = list[processedElements];
                temp2 = list[minIndex];
                list[processedElements] = temp2;
                list[minIndex] = temp1;
                processedElements++;
                minIndex = processedElements;
            }
            return list;
        }
        public static List<int> SortDescending(List<int> unsortedList)
        {
            List<int> list = new List<int>(unsortedList);
            int maxIndex = 0;
            int processedElements = 0;
            int temp1;
            int temp2;
            while (processedElements != list.Count)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == 0)
                        i += processedElements;
                    if (list[maxIndex] < list[i])
                        maxIndex = i;
                }
                temp1 = list[processedElements];
                temp2 = list[maxIndex];
                list[processedElements] = temp2;
                list[maxIndex] = temp1;
                processedElements++;
                maxIndex = processedElements;
            }
            return list;
        }
    }
}
