using System;

namespace CyberSecurityBot
{
    /// <summary>
    /// This is the entry point of the application.
    /// It only creates the Chatbot and starts it.
    /// (Keeps Program.cs clean as required by the assignment - Point 7)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Chatbot chatbot = new Chatbot();
            chatbot.Start();
        }
    }
}
