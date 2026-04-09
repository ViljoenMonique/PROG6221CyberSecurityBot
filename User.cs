using System;

// This is my comment for the commit
// COMMIT: Implemented user name input and personalisation in User.cs
namespace CyberSecurityBot
{
    /// <summary>
    /// STEP 3: Text-Based Greeting and User Interaction
    /// Handles asking the user for their name and personalising the experience.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Stores the user's name so it can be used in responses.
        /// </summary>
        public string Name { get; private set; } = "Friend";

        /// <summary>
        /// Asks the user for their name and greets them personally.
        /// </summary>
        public void AskForName()
        {
            Console.Write("\nHello! What is your name? ");
            string? input = Console.ReadLine()?.Trim();   // ? allows null temporarily

            // Only update name if the user actually typed something
            if (!string.IsNullOrWhiteSpace(input))
            {
                Name = input!;        // ! tells the compiler "I guarantee this is not null"
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n👋 Welcome, {Name}! Nice to meet you.");
            Console.ResetColor();
        }
    }
}
