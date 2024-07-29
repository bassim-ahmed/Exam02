using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class TrueOrFalseQuestion:Question
    {
        public override string Header
        {
            get { return "True | False Question"; }
        }

        public TrueOrFalseQuestion()
        {
            Answers = new Answer[2];
            Answers[0] = new Answer(1, "True");
            Answers[1] = new Answer(2, "False");
        }

        public override void CreateQuestion()
        {
            int rightAnswerId;
            bool Flag;
            // Header
            Console.WriteLine(Header);
            // Question Body and mark

            SetQuestionBodyAndMark();

            // RightAnswer


            do
            {
                Console.WriteLine("Please Enter the right Answer id (1 for true | 2 For False)");
                Flag = int.TryParse(Console.ReadLine(), out rightAnswerId);
            } while (!Flag && (rightAnswerId == 1 || rightAnswerId == 2));

            RightAnswer.Id = rightAnswerId;
            RightAnswer.Text = Answers[rightAnswerId - 1].Text;
            Console.Clear();
        }
    }
}
