using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortingAlgorithms
{
    class Program
    {
        //Sort() and SortWithEveryMethod() let you check time your PC need to sort
        static void Main(string[] args)
        {
            //List<int> data = new List<int>{8, 10,5,4,6,1,19,3};
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            StreamReader sr = new StreamReader("data100000.dat");
            List<int> data = new List<int>(Array.ConvertAll(sr.ReadToEnd().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries), int.Parse));
            sr.Dispose();sr.Close();
            SortWithEveryMethod(data, watch);
            //Sort(InsertionSorting.SortAscending, data, watch);
            Console.ReadLine();
        }
        private static void Sort(Func<List<int>, List<int>> F, List<int> data, System.Diagnostics.Stopwatch watch)
        {
            TimeSpan ts;
            watch.Start();
            List<int> sortedList = F(data);
            watch.Stop();
            ts = watch.Elapsed;
            watch.Reset();
            foreach (int i in sortedList) Console.Write(i + " ");
            Console.WriteLine("\nTime: " + ts.TotalMilliseconds + "ms");
        }
        private static void SortWithEveryMethod(List<int> data, System.Diagnostics.Stopwatch watch)
        {
            TimeSpan ts;
            List<double> time = new List<double>();
            Console.WriteLine("Insertion Sorting:");
            Console.Write("Ascending: ");
            watch.Start();
            List<int> insSrtAsc = InsertionSorting.SortAscending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in insSrtAsc) Console.Write(i + " ");
            Console.Write("\nDescending: ");
            watch.Start();
            List<int> insSrtDesc = InsertionSorting.SortDescending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in insSrtDesc) Console.Write(i + " ");

            Console.WriteLine("\nBubble Sorting:");
            Console.Write("Ascending: ");
            watch.Start();
            List<int> bubSrtAsc = BubbleSorting.SortAscending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in bubSrtAsc) Console.Write(i + " ");
            Console.Write("\nDescending: ");
            watch.Start();
            List<int> bubSrtDesc = BubbleSorting.SortDescending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in bubSrtDesc) Console.Write(i + " ");

            Console.WriteLine("\nSelection Sorting:");
            Console.Write("Ascending: ");
            watch.Start();
            List<int> selSrtAsc = SelectionSorting.SortAscending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in selSrtAsc) Console.Write(i + " ");
            Console.Write("\nDescending: ");
            watch.Start();
            List<int> selSrtDesc = SelectionSorting.SortDescending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in selSrtDesc) Console.Write(i + " ");

            Console.WriteLine("\nMerge sorting:");
            Console.Write("Ascending: ");
            watch.Start();
            List<int> merSrtAsc = MergeSorting.SortAscending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in merSrtAsc) Console.Write(i + " ");
            Console.Write("\nDescending: ");
            watch.Start();
            List<int> merSrtDesc = MergeSorting.SortDescending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in merSrtDesc) Console.Write(i + " ");

            Console.WriteLine("\nCounting sorting:");
            Console.Write("Ascending: ");
            watch.Start();
            List<int> couSrtAsc = CountingSorting.SortAscending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in couSrtAsc) Console.Write(i + " ");
            Console.Write("\nDescending: ");
            watch.Start();
            List<int> couSrtDesc = CountingSorting.SortDescending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in couSrtDesc) Console.Write(i + " ");

            Console.WriteLine("\nBucket sorting:");
            Console.Write("Ascending: ");
            watch.Start();
            List<int> bucSrtAsc = BucketSorting.SortAscending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in bucSrtAsc) Console.Write(i + " ");
            Console.Write("\nDescending: ");
            watch.Start();
            List<int> bucSrtDesc = BucketSorting.SortDescending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in bucSrtDesc) Console.Write(i + " ");

            Console.WriteLine("\nQuickSort:");
            Console.Write("Ascending: ");
            watch.Start();
            List<int> quiSrtAsc = QuickSort.SortAscending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in quiSrtAsc) Console.Write(i + " ");
            Console.Write("\nDescending: ");
            watch.Start();
            List<int> quiSrtDesc = QuickSort.SortDescending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in quiSrtDesc) Console.Write(i + " ");

            Console.WriteLine("\nHeapSort:");
            Console.Write("Ascending: ");
            watch.Start();
            List<int> heaSrtAsc = HeapSorting.SortAscending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in heaSrtAsc) Console.Write(i + " ");
            Console.Write("\nDescending: ");
            watch.Start();
            List<int> heaSrtDesc = HeapSorting.SortDescending(data);
            watch.Stop();
            ts = watch.Elapsed;
            time.Add(ts.TotalMilliseconds);
            watch.Reset();
            foreach (int i in heaSrtDesc) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("time:");
            for (int i = 0; i < time.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("Insertion: ");
                        break;
                    case 2:
                        Console.Write("\nBubble: ");
                        break;
                    case 4:
                        Console.Write("\nSelection: ");
                        break;
                    case 6:
                        Console.Write("\nMerge: ");
                        break;
                    case 8:
                        Console.Write("\nCounting: ");
                        break;
                    case 10:
                        Console.Write("\nBucket: ");
                        break;
                    case 12:
                        Console.Write("\nQuickSort: ");
                        break;
                    case 14:
                        Console.Write("\nHeap: ");
                        break;
                    default:
                        Console.Write(" ");
                        break;
                }
                Console.Write(time[i]);
            }
        }
    }
}
