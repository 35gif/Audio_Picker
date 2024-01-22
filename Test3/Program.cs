using System;
using System.Speech.Synthesis;

class Program
{
    static void Main()
    {
        using (SpeechSynthesizer synth = new SpeechSynthesizer())
        {
            while(true)
            {
                Console.WriteLine("\nEnter text to speak:");
                string text = Console.ReadLine();
                
                Console.WriteLine("Сохранить озвучку в файл mp3? (1 - да, Enter - нет )");
                string answer = Console.ReadKey().KeyChar.ToString();
                if (answer == "1")
                {
                    //установить mp3 файл к файлам программы D:\C#\Тесты\Test3\Test3\bin\Debug
                    synth.SetOutputToWaveFile("test.mp3");
                    synth.Speak(text);
                    synth.SetOutputToDefaultAudioDevice();
                }
                synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
                //настроить скорость голоса
                synth.Rate = 1;
                //настроить громкость голоса
                synth.Volume = 100;
                synth.Speak(text);
            }
        }
    }
}
