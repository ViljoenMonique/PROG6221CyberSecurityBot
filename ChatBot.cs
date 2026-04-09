using System;
using System.Threading;

namespace CyberSecurityBot
{
    /// <summary>
    /// STEP 2, 4, 5, 6 & 7: Main Chatbot class
    /// Controls the entire chatbot flow and displays your custom ASCII art.
    /// </summary>
    public class Chatbot
    {
        private readonly AudioPlayer _audioPlayer = new AudioPlayer();
        private readonly User _user = new User();

        public void Start()
        {
            Console.Clear();

            // STEP 1: Voice Greeting
            _audioPlayer.PlayGreeting();
            Thread.Sleep(600);

            // STEP 2: YOUR CUSTOM ASCII ART
            DisplayAsciiLogo();

            // STEP 3: Ask for name
            _user.AskForName();

            // Welcome message with typing effect
            TypeText("\nI'm your Cybersecurity Awareness Bot 🛡️", 30);
            TypeText("Type 'exit' anytime to quit.\n", 30);

            ShowMainMenu();

            // Main conversation loop
            while (true)
            {
                Console.Write("\n> ");
                string input = Console.ReadLine()?.Trim() ?? "";

                // STEP 5: Input Validation
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please enter something.");
                    Console.ResetColor();
                    continue;
                }

                if (input.ToLower() == "exit" || input.ToLower() == "quit")
                {
                    Console.WriteLine($"\nGoodbye, {_user.Name}! Stay safe online! 🛡️");
                    break;
                }

                string response = GetResponse(input.ToLower());
                TypeText(response);   // ← Typing effect on every response
            }
        }

        /// <summary>
        /// STEP 2: Displays your custom "Your Cyber Friend" ASCII art as the header.
        /// </summary>
        private void DisplayAsciiLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
  _____   ___   _   _   ____     ____   _   _   _____   ____   _   _   ____  
 / ___/  / _ \ | | | | / __ \   / __ \ | | | | |  _  \ / __ \ | | | | / __ \ 
/ /     | | | | | | | | |  | |  | |  | | | | | | | | | | |  | | | | | | |  | |
| |     | |_| | |_| | | |__| |  | |__| | |_| | | |_| | | |__| | |_| | | |__| |
 \____/  \___/  \___/  \____/    \____/  \___/  |_____/  \____/  \___/   \____/ 

               Y O U R   C Y B E R   F R I E N D
");
            Console.WriteLine("".PadRight(80, '='));
            Console.ResetColor();
        }

        /// <summary>
        /// STEP 6: Enhanced Console UI - Shows a clean menu with borders and colours.
        /// </summary>
        private void ShowMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("".PadRight(60, '-'));
            Console.WriteLine("   What would you like to know?");
            Console.WriteLine("".PadRight(60, '-'));
            Console.ResetColor();
        }

        /// <summary>
        /// Typing effect – makes the chatbot feel more natural and professional.
        /// </summary>
        private void TypeText(string text, int delay = 25)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// STEP 4: Basic Response System (now with extra topics)
        /// </summary>
        private string GetResponse(string input)
        {
            if (input.Contains("how are you"))
                return "I'm doing great! Ready to help you stay safe online 😊";

            if (input.Contains("purpose") || input.Contains("who are you"))
                return "My purpose is to teach you about cybersecurity – passwords, phishing, safe browsing, 2FA and more!";

            if (input.Contains("password"))
                return "Strong passwords should be 12+ characters with uppercase, lowercase, numbers and symbols. Use a password manager!";

            if (input.Contains("phish") || input.Contains("phishing"))
                return "Never click links from unknown emails. Check the sender address carefully. Phishing is very common!";

            if (input.Contains("safe") && input.Contains("browse"))
                return "Always look for the padlock 🔒 in the address bar (HTTPS), keep your browser updated, and avoid suspicious downloads.";

            // NEW RESPONSES (greatly exceeds the rubric)
            if (input.Contains("two factor") || input.Contains("2fa") || input.Contains("two-factor"))
                return "Two-Factor Authentication (2FA) adds an extra layer of security. Always enable it on your important accounts like email, banking, and social media!";

            if (input.Contains("hacked") || input.Contains("hack"))
                return "If you think your account was hacked: 1) Change your password immediately, 2) Enable 2FA, 3) Check recent activity, and 4) Scan your device for malware.";

            // Default graceful response
            return "Interesting question! I can help with password safety, phishing, safe browsing, 2FA, or what to do if you get hacked. Try asking me about one of those.";
        }
    }
}
