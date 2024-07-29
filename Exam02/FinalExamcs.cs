using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
            Questions = new Question[NumberOfQuestions];
        }


        public override void CreateQuestions()
        {
            int TypeOfQuestion;
            bool Flag;

            for (int i = 0; i < Questions?.Length; i++)
            {
                do
                {
                    Console.WriteLine("Please Enter Type Of Question (1 for MCQ | 2 For True | False)");
                    Flag = int.TryParse(Console.ReadLine(), out TypeOfQuestion);

                } while (!Flag && (TypeOfQuestion == 1 || TypeOfQuestion == 2));

                Console.Clear();
                // check question type

                switch (TypeOfQuestion)
                {
                    case 1:
                        Questions[i] = new McqQuestion();
                        Questions[i].CreateQuestion();
                        break;
                    case 2:
                        Questions[i] = new TrueOrFalseQuestion();
                        Questions[i].CreateQuestion();
                        break;
                    default:
                      
                        throw  new Exception("Invalid question type");
                }
            }
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


                switch (question)
                {
                    case McqQuestion:
                        do
                        {
                            Console.WriteLine("Please Enter The Answer Id");
                            Flag = int.TryParse(Console.ReadLine(), out userAnswerId);

                        } while (!Flag && (userAnswerId == 1 || userAnswerId == 2 || userAnswerId == 3));
                        break;
                    default:
                        do
                        {
                            Console.WriteLine("Please Enter The Answer Id (1 For True | 2 For False)");
                            Flag = int.TryParse(Console.ReadLine(), out userAnswerId);
                        } while (!Flag && (userAnswerId == 1 || userAnswerId == 2));
                        break;
                }

                question.UserAnswer.Id = userAnswerId;
                question.UserAnswer.Text = question.Answers[userAnswerId - 1].Text;

            }

            Console.Clear();

            // Calculate Marks

            CalculateAndDisplayGrade(Questions);
        }
    }
}
