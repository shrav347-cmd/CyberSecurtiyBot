using CyberSecurityBot;
using CyberSecurtiyBot;

static void Main(string[] args)
{
    Chatbot bot = new Chatbot();
    User currentUser = new User();
    ResponseHandler handler = new ResponseHandler();

    bot.Start(); 

    Console.WriteLine("Please enter your name to begin:");
    string inputName = Console.ReadLine();

    
    currentUser.Name = string.IsNullOrWhiteSpace(inputName) ? "Guest" : inputName;

    Console.WriteLine($"\nWelcome {currentUser.Name}! How can I help you with Cybersecurity today?");

    
    for (int i = 0; i < 3; i++)
    {
        Console.Write("\nAsk me a question (e.g., about passwords): ");
        string userQuestion = Console.ReadLine() ?? "";
        string response = handler.GetResponse(userQuestion);
        Console.WriteLine(response);
    }
}