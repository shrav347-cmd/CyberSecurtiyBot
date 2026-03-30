using System;
using System.Media; 
namespace CyberSecurtiyBot
{
    public class Chatbot
    {
        
        public string WelcomeAudioPath { get; set; } = "welcome.wav";

        public void Start(string userName)
        {
            DisplayHeader();
            PlayVoiceGreeting();
            Console.WriteLine($"\n[Bot]: Hello {userName}! I am your Cybersecurity Assistant.");
            Console.WriteLine("[Bot]: I can help you with Passwords, Phishing, and MFA. What is your question?");
        }

        
        public void DisplayHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
            ________________________________________________
            |                                              |
            |      SECURE-BOT: CYBER AWARENESS v1.0        |
            |______________________________________________|
            ");
            Console.WriteLine("                [ WARNING: STAY SAFE ONLINE ]               ");
            Console.WriteLine();
            Console.ResetColor();
        }

        
        public void PlayVoiceGreeting()
        {
            try
            {
                
                using (SoundPlayer player = new SoundPlayer(WelcomeAudioPath))
                {
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("(Audio greeting skipped: " + ex.Message + ")");
            }
        }
    }
}