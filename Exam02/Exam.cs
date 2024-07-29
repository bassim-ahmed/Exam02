using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Exam
    {
        private int time;
        private int numberofquestions;
        public Question[] Questions { get; set; }

        public int Time
        {
            get { return time; }
            set { time = value > 0 ? value : throw new Exception("Exam time must be greater than 0 minutes"); }
        }
        public int NumberOfQuestions
        {
            get { return numberofquestions; }
            set { numberofquestions = value > 0 ? value : throw new Exception("number of question must be greater than zero"); }
        }
        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public abstract void CreateQuestions();
        public abstract void ShowExam();

        public void CalculateAndDisplayGrade(Question[] questions)
        {
            int grade = 0, totalMarks = 0;

            for (int i = 0; i < questions?.Length; i++)
            {
                totalMarks += questions[i].Mark;

                if (questions[i].UserAnswer.Id == questions[i].RightAnswer.Id)
                {
                    grade += questions[i].Mark;
                }

                Console.WriteLine($"Question {i + 1} : {questions[i].Body}");
                Console.WriteLine($"Your Answer => {questions[i].UserAnswer.Text}");
                Console.WriteLine($"Right Answer => {questions[i].RightAnswer.Text}");
            }

            Console.WriteLine($"Your Grade is {grade} from {totalMarks}");
        }
    }
}
