using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class McqQuestion : Question
    {
        public override string Header
        {
            get { return "MCQ Question"; }
        }

        public McqQuestion()
        {
            Answers = new Answer[3];
        }

        public override void CreateQuestion()
        {
            int rightAnswerId;
            bool Flag;

            // Header
            Console.WriteLine(Header);
            //question body and mark
            SetQuestionBodyAndMark();

            // Choices
            Console.WriteLine("Choices Of Question");

            for (int i = 0; i < Answers.Length; i++)
            {
                Answers[i] = new Answer() { Id = i + 1 };

                // Text
                do
                {
                    Console.WriteLine($"Please Enter Choice Number {i + 1}");
                    Answers[i].Text = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(Answers[i].Text));

            }

            // RightAnswer

            do
            {
                Console.WriteLine("Please Enter the right Answer NUMBER");
                Flag = int.TryParse(Console.ReadLine(), out rightAnswerId);

            } while (!Flag && (rightAnswerId == 1 || rightAnswerId == 2 || rightAnswerId == 3));

            RightAnswer.Id = rightAnswerId;
            RightAnswer.Text = Answers[rightAnswerId - 1].Text;
            Console.Clear();
        }
    }
}
