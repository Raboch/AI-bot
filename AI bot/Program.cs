using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] answers = { "Здравствуйте", "Хорошо", "Пока" };
            string[] questions = { "Здравствуйте", "Как дела", "Пока" };


            while (true)
            {
                string question = Console.ReadLine(); // Задаем вопрос роботу - как дела

                for (int i = 0; i < questions.Length; i++)
                {
                    if (questions[i] == question) // Если question(вопрос) == questions[i] => answers[i]
                    {
                        Console.WriteLine(answers[i]); // То ответит - answer[i]
                    }
                }

                if ("Пока" == question)
                {
                    break;
                }
            }

            Console.ReadKey();
        }

    }
}
