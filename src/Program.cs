using System;
using System.Globalization;
using System.Speech.Synthesis;

namespace poc_text_to_speech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Rate = 3;
            var builder = new PromptBuilder();
            builder.StartVoice(new CultureInfo("pt-BR"));
            builder.AppendText("BORA BORA - CORRE QUE TA ACABANDO!!");
            builder.EndVoice();
            synthesizer.Speak(builder);
            Console.WriteLine("FOI");
        }
    }
}
