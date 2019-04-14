using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //new ExerciseOne().DoExercise();

            //Array sorting
            var arrayForSorting = new int[] { 5, 3, 2, 6, 7, 8, 12, 15, 9, 13 };

            var sortExercise = new SortArrayExercise();
            var sortedArray = sortExercise.BubbleSort(arrayForSorting);

            new List<int>(sortedArray).ForEach(e => Console.WriteLine($"{e}"));


            Console.ReadKey();
        }
    }
}
