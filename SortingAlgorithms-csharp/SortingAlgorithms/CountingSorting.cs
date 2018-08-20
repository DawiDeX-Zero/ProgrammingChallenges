using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{

    //
    //  Counting Sort
    //  Input Value: Be aware of too big range
    //  Not very efficient because of very large histogram size
    //
    class CountingSorting
    {
        public static List<int> SortAscending(List<int> unsortedList)
        {
            int min = unsortedList.Min();
            int max = unsortedList.Max();
            List<int> histogram = new List<int>();
            List<int> list = new List<int>();
            int k = 0;
            for(int i = min; i<=max;i++)
            {
                histogram.Add(unsortedList.Where(x => x.Equals(i)).Count());
            }
            for (int i = min; i <= max; i++)
            {
                for(int j = 0;j<histogram[k];j++)
                {
                    list.Add(i);
                }
                k++;
            }
            return list;
        }
        public static List<int> SortDescending(List<int> unsortedList)
        {
            int min = unsortedList.Min();
            int max = unsortedList.Max();
            List<int> histogram = new List<int>();
            List<int> list = new List<int>();
            int k = 0;
            for (int i = max; i >= min; i--)
            {
                histogram.Add(unsortedList.Where(x => x.Equals(i)).Count());
            }
            for (int i = max; i >= min; i--)
            {
                for (int j = 0; j < histogram[k]; j++)
                {
                    list.Add(i);
                }
                k++;
            }
            return list;
        }
    }
}
