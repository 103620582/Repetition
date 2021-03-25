using System;

namespace RepetitionLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Please enter a number of times to repeat.");
            string input2 = Console.ReadLine();
            int number = int.Parse(input2);
            
            int counter = 0;

            while (counter < number)
            {
                System.Console.WriteLine("Please enter a name.");
                string name = Console.ReadLine();

                counter++;
            }

            System.Console.WriteLine("Goodbye.");

        
        }
    }
}

