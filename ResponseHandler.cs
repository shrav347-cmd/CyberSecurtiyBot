namespace CyberSecurityBot.Classes;

public class ResponseHandler
{
    public string GetResponse(string input)
    {
        input = input.ToLower();

        if (input.Contains("password"))
            return "Use strong passwords.";

        return "I didn’t understand that.";
    }
}