using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class RemoveDuplicatesExercise
    {
        public void RemoveDuplicates()
        {
            int[] arrayWithDuplicates = { 1, 1, 2, 2, 3, 3, 4, 4, 4, 5, 5, 6, 7, 7, 7, 7, 9, 9, 9 };
            Console.WriteLine(string.Concat(arrayWithDuplicates));
            HashSet<int> hashedArray = arrayWithDuplicates.ToHashSet();
            Console.WriteLine(string.Concat(hashedArray));
        }
    }
}
