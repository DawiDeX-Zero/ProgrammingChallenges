using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class MergeSorting
    {
        public static List<int> SortAscending(List<int> unsortedList)
        {
            bool sortAscending = true;
            List<int[]> temp1 = new List<int[]>();
            List<int[]> temp2 = new List<int[]>();
            List<int> mergedList = new List<int>();
            Split(unsortedList, temp1);

            while(temp1.Count!=1)
            {
                if(temp1.Count%2 == 0)
                {
                    for (int i = 0; i<temp1.Count; i += 2)
                    {
                        Merge(temp1[i], temp1[i + 1], temp2, sortAscending);
                    }
                }
                else
                {
                    for (int i = 0; i < temp1.Count-1; i += 2)
                    {
                        Merge(temp1[i], temp1[i + 1], temp2, sortAscending);
                    }
                    temp2.Add(temp1[temp1.Count-1]);
                }
                temp1 = new List<int[]>(temp2);
                temp2.Clear();
            }
            for(int i=0;i<temp1.Count;i++)
            {
                for(int j=0;j<temp1[i].Length;j++)
                {
                    mergedList.Add(temp1[i][j]);
                }
            }
            return mergedList;
        }

        public static List<int> SortDescending(List<int> unsortedList)
        {
            bool sortAscending = false;
            List<int[]> temp1 = new List<int[]>();
            List<int[]> temp2 = new List<int[]>();
            List<int> mergedList = new List<int>();
            Split(unsortedList, temp1);

            while (temp1.Count != 1)
            {
                if (temp1.Count % 2 == 0)
                {
                    for (int i = 0; i < temp1.Count; i += 2)
                    {
                        Merge(temp1[i], temp1[i + 1], temp2, sortAscending);
                    }
                }
                else
                {
                    for (int i = 0; i < temp1.Count - 1; i += 2)
                    {
                        Merge(temp1[i], temp1[i + 1], temp2, sortAscending);
                    }
                    temp2.Add(temp1[temp1.Count - 1]);
                }
                temp1 = new List<int[]>(temp2);
                temp2.Clear();
            }
            for (int i = 0; i < temp1.Count; i++)
            {
                for (int j = 0; j < temp1[i].Length; j++)
                {
                    mergedList.Add(temp1[i][j]);
                }
            }
            return mergedList;
        }

        private static void Merge(int[] left, int[] right, List<int[]> listOfNewGroups, bool sortAscending)
        {
            int[] mergedArray = new int[left.Length + right.Length];
            int i = 0; //left array iterator
            int j = 0; //right array iterator
            int k = 0; //merged array iterator
            bool condition = true;
            while(condition)
            {
                if (i==left.Length)
                {
                    mergedArray[k] = right[j];
                    j++;
                    k++;
                }
                else if(j==right.Length)
                {
                    mergedArray[k] = left[i];
                    i++;
                    k++;
                }
                else if (left[i] < right[j])
                {
                    if(sortAscending==true)
                    {
                        mergedArray[k] = left[i];
                        i++;
                        k++;
                    }
                    else
                    {
                        mergedArray[k] = right[j];
                        j++;
                        k++;
                    }
                }
                else if (right[j] < left[i])
                {
                    if (sortAscending == true)
                    {
                        mergedArray[k] = right[j];
                        j++;
                        k++;
                    }
                    else
                    {
                        mergedArray[k] = left[i];
                        i++;
                        k++;
                    }
                }
                else if(left[i]==right[j])
                {
                    mergedArray[k++] = left[i++];
                    mergedArray[k++] = right[j++];
                }
                if (!(i < left.Length) && !(j < right.Length))
                {
                    condition = false;
                }  
            }
            listOfNewGroups.Add(mergedArray);
            
        }
        private static void Split(List<int> unsortedList, List<int[]> temp)
        {
            for(int i=0;i<unsortedList.Count;i++)
            {
                temp.Add(new int[] { unsortedList[i] });
            }
        }
    }
}
