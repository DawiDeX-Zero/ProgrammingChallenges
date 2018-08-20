using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    //
    //  Bucket Sorting
    //  It is based on Insertion Sorting
    //  Input Value:Only non-negative numbers
    //  Not very efficient with big numbers
    //
    class BucketSorting
    {
        public static List<int> SortAscending(List<int> unsortedList)
        {
            List<int> list = new List<int>();
            int min = unsortedList.Min();
            int max = unsortedList.Max();
            int buckets = 10;
            int divider = (int)Math.Ceiling(Convert.ToDecimal(((max + 1) / buckets)));
            if(divider>9)
            {
                divider = 9;
                buckets = (int)Math.Ceiling((decimal)max/9);
            }
            List<int>[] bucketsArray = new List<int>[buckets]; 
            for(int i=0;i<unsortedList.Count;i++)
            {
                AddToBucket(bucketsArray, (int)Math.Floor(Convert.ToDecimal(unsortedList[i] / divider)), unsortedList[i]);
            }
            for(int i=0;i<bucketsArray.Length;i++)
            {
                if(bucketsArray[i] != null)
                {
                    if (bucketsArray[i].Count != 1)
                        list.AddRange(InsertionSorting.SortAscending(new List<int>(bucketsArray[i])));
                    else
                        list.Add(bucketsArray[i][0]);
                }
            }
            return list;
        }
        public static List<int> SortDescending(List<int> unsortedList)
        {
            List<int> list = new List<int>();
            int min = unsortedList.Min();
            int max = unsortedList.Max();
            int buckets = 10;
            int divider = (int)Math.Ceiling(Convert.ToDecimal(((max + 1) / buckets)));
            if (divider > 9)
            {
                divider = 9;
                buckets = (int)Math.Ceiling((decimal)max / 9);
            }
            List<int>[] bucketsArray = new List<int>[buckets];
            for (int i = 0; i < unsortedList.Count; i++)
            {
                AddToBucket(bucketsArray, (int)Math.Floor(Convert.ToDecimal(unsortedList[i] / divider)), unsortedList[i]);
            }
            for (int i = bucketsArray.Length-1; i >= 0; i--)
            {
                if (bucketsArray[i] != null)
                {
                    if (bucketsArray[i].Count != 1)
                        list.AddRange(InsertionSorting.SortDescending(new List<int>(bucketsArray[i])));
                    else
                        list.Add(bucketsArray[i][0]);
                }
            }
            return list;
        }

        private static void AddToBucket(List<int>[] bucketArray, int index, int value)
        {

            if (bucketArray[index] == null)
            {
                bucketArray[index] = new List<int>() { value };
            }
            else
            {
                bucketArray[index].Add(value);
            }
        }
    }
}
