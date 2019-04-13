using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(new ExerciseOne().FindMostFrequentCharacterInString("TeeeestStringSomeInput"));
            Console.WriteLine(new ExerciseOne().FindMostFrequentCharacterInStringWithLINQ("TeeeestStringSomeInput"));
            Console.ReadKey();
        }
    }
}
