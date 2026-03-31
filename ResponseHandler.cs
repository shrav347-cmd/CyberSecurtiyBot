using System;

namespace CyberSecurtiyBot
{
    public class ResponseHandler
    {
        
        public string GetResponse(string input)
        {
            // Converting to lowercase once here so I don't have to check 
            // for 'MFA', 'mfa', and 'Mfa' separately.
            input = input.ToLower();
            // Simple keyword matching logic to provide security advice.
            if (input.Contains("password"))
                return "[Bot]: A strong password should be at least 12 characters long and include numbers and symbols.";

            if (input.Contains("phishing"))
                return "[Bot]: Phishing is a scam where attackers send fake emails to steal your login details. Don't click suspicious links!";

            if (input.Contains("mfa") || input.Contains("factor"))
                return "[Bot]: Multi-Factor Authentication (MFA) adds a second layer of security, like a code sent to your phone.";

            return "[Bot]: I'm sorry, I don't recognize that topic. Try asking about Passwords, Phishing, or MFA.";
        }
    }
}