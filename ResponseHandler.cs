namespace CyberSecurtiyBot // Removed the .Classes part to match Program.cs
{
    public class ResponseHandler
    {
        public string GetResponse(string input)
        {
            input = input.ToLower();
            if (input.Contains("password"))
                return "Use strong, unique passwords for every account.";

            return "I didn't quite understand that. Could you rephrase?";
        }
    }
}