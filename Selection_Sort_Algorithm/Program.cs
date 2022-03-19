using System;

namespace Selection_Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 7, 4, 10, 8, 3, 1 };
            var sortedArray = SelectionSort(arr);
            foreach (var item in sortedArray)
            {
                Console.Write(item+ " ");
            }
            Console.ReadLine();
        }
        public static int[] SelectionSort(int[] arr)
        {
            int j;
            int minIndex;
            for (int i = 0; i < arr.Length-1; i++)
            {
                //we assume first element is min
                minIndex = i;

                for ( j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        //we found new min value
                        minIndex = j;
                    }
                }

                if(minIndex != i)
                {
                    int temp = arr[minIndex];
                    arr[minIndex] = arr[i];
                    arr[i] = temp;

                }

            }
            return arr;
        }
    }
}
