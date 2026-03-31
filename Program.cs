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
            ResponseHandler handler = new ResponseHandler();

            Console.WriteLine("What is your name?");
            string input = Console.ReadLine() ?? "";
            user.Name = string.IsNullOrWhiteSpace(input) ? "Guest" : input;

            bot.Start(user.Name);

            bool isRunning = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Welcome, {user.Name}. The Secure Database is now online.");
            while (isRunning)
            {
                Console.Write("\n[You]: ");
                string userQuestion = Console.ReadLine() ?? "";

                if (userQuestion.ToLower() == "exit" || userQuestion.ToLower() == "quit")
                {
                    isRunning = false;
                    Console.WriteLine("[Bot]: Stay safe online. Goodbye!");
                }
                else
                {
                    string botAnswer = handler.GetResponse(userQuestion);
                    Console.WriteLine(botAnswer);
                }
            }
        }
    }
}