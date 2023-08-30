using System;

namespace Collection
{
    public class ListExample
    {
        public void RunListOperations()
        {
           
            List<int> numbers = new List<int>();

            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(20);
            Console.Write("numbers: ");
            
            foreach(int i in numbers)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            numbers.Insert(1, 8);   
            Console.Write("numbers: ");
            Console.WriteLine();
            foreach (int i in numbers)
            {
                Console.Write(i);
            }
            numbers.InsertRange(3, new List<int> { 12, 18 });  

            int firstElement = numbers[0];
            int lastElement = numbers[numbers.Count - 1];

            numbers[2] = 25;  

            bool contains15 = numbers.Contains(15);

            int index15 = numbers.IndexOf(15);

            numbers.Remove(10);    
            numbers.RemoveAt(2);    
            numbers.RemoveRange(0, 2);  

            numbers.Clear();

            List<string> names = new List<string>
        {
            "Alice",
            "Bob",
            "Charlie"
        };

            names.Sort();

            names.Reverse();

  
            List<string> copiedNames = new List<string>(names);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

     
            int count = names.Count;

  
            bool isEmpty = names.Count == 0;

            string[] namesArray = names.ToArray();
        }
    }
}
