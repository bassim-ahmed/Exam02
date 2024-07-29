using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Question
    {
        public abstract string Header { get; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }

        public Question()
        {
            RightAnswer = new Answer();
            UserAnswer = new Answer();
        }

        public abstract void CreateQuestion();
        public void SetQuestionBodyAndMark()
        {
            int mark;
            bool Flag;
            // Question Body

            do
            {
                Console.WriteLine("Please Enter Question Body");
                Body = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Body));

            // Mark


            do
            {
                Console.WriteLine("Please Enter Question Mark");
                Flag = int.TryParse(Console.ReadLine(), out mark);

            } while (!Flag && (mark > 0));
            Mark = mark;


        }
        public override string ToString()
        {
            return $"{Header} \t Mark{Mark} \n " +
                   $"\n{Body} \n";
        }
    }
}
