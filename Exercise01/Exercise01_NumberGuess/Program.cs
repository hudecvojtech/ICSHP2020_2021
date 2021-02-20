using System;

namespace Exercise01_NumberGuess
{
    class Program
    {
        static string numberGuess(int search, int guess)
        {
            if (search < guess) return "Searched number is lower";
            if (search > guess) return "Searched number is higher";
            return "Found";
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            bool game = true;
            while (game)
            {
                int search = random.Next(100);
                int counter = 0;
                while (counter < 10)
                {
                    Console.WriteLine("Enter your guess: ");
                    int guess = 0;
                    try
                    {
                        guess = Int32.Parse(Console.ReadLine());
                        string result = numberGuess(search, guess);
                        Console.WriteLine(result);
                        if (result == "Found") break;
                        counter++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Your input is not number");
                    }                    
                }

                Console.WriteLine("Play again? (Y/N)");
                string again = Console.ReadLine();
                if (again.ToUpper() != "Y") game = false;
            }
          
        }
    }
}
