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
            if (command == "names")
            {
                var allNames = new[] { "Legolas", "Arwen", "David", "Dana", "Felicia", "Felix" };
                var randomIndex = rnd.Next(allNames.Length);
                Console.WriteLine(allNames[randomIndex]);
            }
            Console.ReadKey();
        }
    }
}
