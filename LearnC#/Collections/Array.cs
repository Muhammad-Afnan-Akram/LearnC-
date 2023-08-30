using System;

namespace Collection
{
    public class ArrayExample
    {
        public void RunArrayOperations()
        {
            int[] numbers = { 1, 87, 19, 4, 5 ,6,7,8,9,10};
            Console.Write("Array elements: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Element at index 2: " + numbers[2]);

            numbers[3] = 8;
            Console.WriteLine("Modified element at index 3: " + numbers[3]);
            Console.Write("Array elements: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array length: " + numbers.Length);

            

            Array.Sort(numbers);
            Console.Write("Sorted array: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Array.Reverse(numbers);
            Console.Write("Reversed array: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
         
            int[] copyArray = new int[numbers.Length];
         
            Array.Copy(numbers, copyArray, numbers.Length);
            Console.Write("Copied array: ");
            foreach (int num in copyArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int[,] multiDimArray = { { 1, 2, 3 }, { 4, 5, 6 } };

            int rows = multiDimArray.GetLength(0);
            int cols = multiDimArray.GetLength(1);
            Console.WriteLine("Rows: " + rows + ", Columns: " + cols);

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            Console.WriteLine("Element at jaggedArray[1][1]: " + jaggedArray[1][1]);

            // Searching for an element
            int index = Array.IndexOf(numbers, 4);
            Console.WriteLine("Index of 4: " + index);

            // Checking if an element exists
            bool contains = Array.Exists(numbers, element => element == 3);
            Console.WriteLine("Array contains 3: " + contains);

            // Clearing elements
            Array.Clear(numbers, 1, 2); // Clears two elements starting from index 1
            Console.Write("Cleared array: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();


        }
    }
}
