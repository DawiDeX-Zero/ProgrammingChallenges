using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class InsertionSorting
    {
        public static List<int> SortAscending(List<int> unsortedList)
        {
            List<int> list = new List<int> {unsortedList[0]};
            for (int i = 1; i < unsortedList.Count; i++)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (unsortedList[i] < list[j] || unsortedList[i] == list[j])
                        {
                            list.Insert(j, unsortedList[i]);
                            break;
                        }
                        else if (j == list.Count - 1)
                        {
                            list.Add(unsortedList[i]);
                            break;
                        }  
                    }
                } 
            return list;
        }

        public static List<int> SortDescending(List<int> unsortedList)
        {
            List<int> list = new List<int> {unsortedList[0]};
            for (int i = 1; i < unsortedList.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (unsortedList[i] > list[j] || unsortedList[i] == list[j])
                    {
                        list.Insert(j, unsortedList[i]);
                        break;
                    }
                    else if (j == list.Count - 1)
                    {
                        list.Add(unsortedList[i]);
                        break;
                    }
                }
            }
            return list;
        }
    }
}
