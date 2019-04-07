using System;

namespace Arrays
{
    //Find the largsest/smallest number in unsorter array
    public class ExerciseOne
    {
        public void DoExercise()
        {
            var unsortedArray = new int[20];
            var numbGenerator = new Random();
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = numbGenerator.Next(1, 100);
            }

            int largestNumber = 0;
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                if (largestNumber < unsortedArray[i])
                    largestNumber = unsortedArray[i];
            }

            Console.WriteLine($"The largest number in array is {largestNumber}");
        }
    }
}
