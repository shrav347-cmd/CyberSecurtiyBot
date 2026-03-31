using CyberSecurityBot;
using System;

namespace CyberSecurtiyBot
{
    class Program
    {
        static void Main(string[] args)
        { // Setting up the 'team' - each object has a specific job to do.
            Chatbot bot = new Chatbot();
            User user = new User();
            ResponseHandler handler = new ResponseHandler();
            // Making sure the bot doesn't break if the user just hits 'Enter'
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine() ?? "";
            user.Name = string.IsNullOrWhiteSpace(input) ? "Guest" : input;
            // This triggers the audio greeting. 
            // I'm passing the name here so the bot feels more interactive.
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