using CyberSecurityBot;
using System;

namespace CyberSecurtiyBot
{
    // The class must be inside the namespace
    class Program
    {
        // The Main method must be inside the class
        static void Main(string[] args)
        {
            Chatbot bot = new Chatbot();
            User user = new User();

            Console.WriteLine("Please enter your name:");
            string input = Console.ReadLine() ?? "";
            user.Name = string.IsNullOrWhiteSpace(input) ? "Guest" : input;

            bot.Start(user.Name);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}