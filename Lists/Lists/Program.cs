using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int> { 2, 5, 0 };
            PrintList(intList);
            PrintCountAndCapacity(intList);

            intList.Add(4);
            intList.Add(5);
            PrintList(intList);
            PrintCountAndCapacity(intList);

            intList.Insert(2, 7);
            PrintList(intList);

            intList.Remove(5);
            PrintList(intList);

            intList.RemoveAt(2);
            PrintList(intList);

            intList.Clear();
            PrintList(intList);
            PrintCountAndCapacity(intList);

            for (int i = 0; i < 10; i++)
                intList.Add(i * i);
            PrintList(intList);
            PrintCountAndCapacity(intList);

            Console.WriteLine(intList.Contains(25));
            Console.WriteLine(intList.Contains(11));

            intList.Insert(7, 4);
            PrintList(intList);
            Console.WriteLine(intList.IndexOf(4));
            Console.WriteLine(intList.LastIndexOf(4));
            Console.WriteLine(intList.LastIndexOf(11));

            intList.Insert(4, intList[9]);
            intList.RemoveAt(10);
            Console.WriteLine();
            PrintList(intList);

            ListQuickSort(intList);
            PrintList(intList);
        }

        static void PrintList(List<int> list)
        {
            foreach(int elem in list)
                Console.WriteLine(elem);

            Console.WriteLine();
        }

        static void PrintCountAndCapacity(List<int> list)
        {
            Console.WriteLine(list.Count + " " + list.Capacity);
            Console.WriteLine();
        }

        static void ListQuickSort(List<int> list)
        {
            if(list.Count == 0) return;

            var x = list[0];
            list.RemoveAt(0);

            var left = new List<int>();
            var right = new List<int>();

            foreach (int y in list)
                if (y < x)
                    left.Add(y);
                else
                    right.Add(y);

            ListQuickSort(left);
            ListQuickSort(right);

            list.Clear();
            list.AddRange(left);
            list.Add(x);
            list.AddRange(right);
        }            
    }
}
