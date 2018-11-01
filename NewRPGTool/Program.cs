using System;

namespace NewRPGTool
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("What do you need?");
            var command = Console.ReadLine();
            if (command == "roll d20")
            {
                var diceRoll = rnd.Next(20) + 1;
                Console.WriteLine($"Your dice roll is: {diceRoll}");
            }
            if (command == "names")
            {
                var allNames = new[] { "Legolas", "Arwen", "Bjorn", "Sam", "Bard", "Morgoth" };
                var randomIndex = rnd.Next(allNames.Length);
                Console.WriteLine(allNames[randomIndex]);
            }
            Console.ReadKey();

            
        }
    }
}
