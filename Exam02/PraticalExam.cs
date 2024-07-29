using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
            Questions = new McqQuestion[NumberOfQuestions];
        }

        public override void CreateQuestions()
        {


            for (int i = 0; i < Questions?.Length; i++)
            {
                Console.WriteLine($"question number: {i + 1}");
                Questions[i] = new McqQuestion();
                Questions[i].CreateQuestion();
            }

            Console.Clear();
        }

        public override void ShowExam()
        {
            int userAnswerId;
            bool Flag;
            foreach (var question in Questions)
            {
                Console.WriteLine(question);

                for (int i = 0; i < question?.Answers?.Length; i++)
                    Console.WriteLine(question.Answers[i]);

                Console.WriteLine("----------------------------------------");


                do
                {
                    Console.WriteLine("Please Enter The Answer number");
                    Flag = int.TryParse(Console.ReadLine(), out userAnswerId);
                } while (!Flag && (userAnswerId == 1 || userAnswerId == 2 || userAnswerId == 3));

                question.UserAnswer.Id = userAnswerId;
                question.UserAnswer.Text = question.Answers[userAnswerId - 1].Text;

            }

            Console.Clear();

            CalculateAndDisplayGrade(Questions);
        }
    }
}
