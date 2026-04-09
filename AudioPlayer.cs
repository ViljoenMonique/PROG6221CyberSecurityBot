using System;
using System.Media;

namespace CyberSecurityBot
{
    /// <summary>
    /// STEP 1: Voice Greeting (VERY IMPORTANT)
    /// This class is responsible for playing the recorded voice greeting.
    /// </summary>
    public class AudioPlayer
    {
        /// <summary>
        /// Plays the greeting.wav file from the Assets folder.
        /// </summary>
        public void PlayGreeting()
        {
            try
            {
                // Correct path because greeting.wav is inside the Assets folder
                using (SoundPlayer player = new SoundPlayer(@"Assets\greeting.wav"))
                {
                    Console.WriteLine("🎵 Playing voice greeting...");
                    player.PlaySync(); // Plays and waits until finished
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"⚠️ Could not play greeting: {ex.Message}");
                Console.WriteLine("Make sure greeting.wav is inside the Assets folder and set to 'Copy always'.");
                Console.ResetColor();
            }
        }
    }
}