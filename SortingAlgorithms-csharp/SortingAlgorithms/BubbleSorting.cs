using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class BubbleSorting
    {
        public static List<int> SortAscending(List<int> unsortedList)
        {
            List<int> list = new List<int>(unsortedList);
            bool flag = true;
            while(flag)
            {
                flag = false;
                for (int i = 0; i < list.Count; i++)
                {
                    try
                    {
                        if (list[i] > list[i + 1])
                        {
                            int temp1 = list[i + 1];
                            int temp2 = list[i];
                            list[i] = temp1;
                            list[i + 1] = temp2;
                            flag = true;
                        }
                    }
                    catch (ArgumentOutOfRangeException) { }
                }
            }
            return list;
        }
        public static List<int> SortDescending(List<int> unsortedList)
        {
            List<int> list = new List<int>(unsortedList);
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < list.Count; i++)
                {
                    try
                    {
                        if (list[i] < list[i + 1])
                        {
                            int temp1 = list[i + 1];
                            int temp2 = list[i];
                            list[i] = temp1;
                            list[i + 1] = temp2;
                            flag = true;
                        }
                    }
                    catch (ArgumentOutOfRangeException) { }
                }
            }
            return list;
        }
    }
}
