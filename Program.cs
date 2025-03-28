using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
using System.Speech.Synthesis;

namespace CyberSecChatbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ASCII Art 
            Console.WriteLine("       ");
            Console.WriteLine(" ██████ ██    ██ ██████  ███████ ██████  ██████   ██████  ██      ██  ██████ ███████   \r\n██       ██  ██  ██   ██ ██      ██   ██ ██   ██ ██    ██ ██      ██ ██      ██        \r\n██        ████   ██████  █████   ██████  ██████  ██    ██ ██      ██ ██      █████     \r\n██         ██    ██   ██ ██      ██   ██ ██      ██    ██ ██      ██ ██      ██        \r\n ██████    ██    ██████  ███████ ██   ██ ██       ██████  ███████ ██  ██████ ███████   \r\n                                                                                       \r\n                                                                                       \r\n               ██████ ██   ██  █████  ████████ ██████   ██████  ████████               \r\n              ██      ██   ██ ██   ██    ██    ██   ██ ██    ██    ██                  \r\n    █████     ██      ███████ ███████    ██    ██████  ██    ██    ██        █████     \r\n              ██      ██   ██ ██   ██    ██    ██   ██ ██    ██    ██                  \r\n               ██████ ██   ██ ██   ██    ██    ██████   ██████     ██                  \r\n                                                                                       \r\n                                                                                       ");

            // configure Speech Synthesizer
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Volume = 100;  // Set Volume (0-100)
            synth.Rate = 0;      // Set Speed (-10 to 10)
            synth.SelectVoiceByHints(VoiceGender.Female); // Choose Female voice

            // Greeting
            string greeting = "Hello, I am a Cybersecurity Awareness Assistant. What is your name?";
            Console.WriteLine(greeting);
            synth.Speak(greeting);


            // Get user's name
            string userName = Console.ReadLine();

            // create a greeting with the user's name
            string personalizedGreeting = $"Hello {userName}, how can I assist you with cybersecurity today? Feel free to ask me anything!";
            Console.WriteLine(personalizedGreeting);
            synth.Speak(personalizedGreeting);

        }
    }
}
