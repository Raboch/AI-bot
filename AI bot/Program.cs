using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.IO;

namespace AI_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] answers = { "Здравствуйте", "Хорошо", "Пока" };
            //string[] questions = { "Здравствуйте", "Как дела?", "Пока" };
            List<string> answers = File.ReadAllLines("answers.txt").ToList();
            List<string> questions = File.ReadAllLines("questions.txt").ToList();
            string idk = "I don't know, i'am too small you little idiot). But ok i remember";

            //File.WriteAllLine("questions.txt", questions);

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();

            string question = "";

            do
            {
                question = Console.ReadLine(); // Задаем вопрос роботу - как дела

                for (int i = 0; i < questions.Count; i++)
                {
                    if (questions[i] == question) // Если question(вопрос) == questions[i] => answers[i]
                    {
                        Console.WriteLine(answers[i]); // То ответит - answer[i]
                        synth.Speak(answers[i]);

                        break;
                    }
                    else if (i == questions.Count - 1)
                    {
                        Console.WriteLine("I don't know, i'am too small you little idiot). But ok i remember");
                        synth.Speak(idk);

                        questions.Add(question);
                        answers.Add(Console.ReadLine());
                        File.WriteAllLines("questions.txt", questions);
                        File.WriteAllLines("answers.txt", answers);
                    }
                }

                
            }
            while ("bye" != question);

            Console.ReadKey();
        }
 
    }
}
