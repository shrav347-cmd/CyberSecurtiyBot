using CyberSecurityBot;
using System;

namespace CyberSecurtiyBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Chatbot bot = new Chatbot();
            User user = new User();

            Console.WriteLine("Enter your name:");
            // The ?? "" fixes the "null literal" warning
            string input = Console.ReadLine() ?? "";

            // Input Validation (Required for marks)
            user.Name = string.IsNullOrWhiteSpace(input) ? "Guest" : input;

            // This fixes the 'no argument given' error
            bot.Start(user.Name);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}