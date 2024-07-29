using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam Exam { get; set; }





        public void CreateExam()
        {
            int ExamType, Time, NumOfQuestions;
            bool Flag;
            // 1. create exam Final - Practical         
            do
            {
                Console.WriteLine($"Please Enter The Type Of Exam (1 For Practical | 2 For final)");
                Flag = int.TryParse(Console.ReadLine(), out ExamType);
            } while (!Flag || !(ExamType == 1 || ExamType == 2));


            do
            {
                Console.WriteLine("Please Enter the time For Exam From ");
                Flag = int.TryParse(Console.ReadLine(), out Time);

            } while (!Flag || !(Time > 0));

            do
            {
                Console.WriteLine("Please Enter the Number Of questions");
                Flag = int.TryParse(Console.ReadLine(), out NumOfQuestions);
            } while ((!Flag) && !(NumOfQuestions > 0));
            //2.  check type of exam
            if (ExamType == 1)
                Exam = new PracticalExam(Time, NumOfQuestions);
            else
                Exam = new FinalExam(Time, NumOfQuestions);

            Console.Clear();
            // 3. Create Questions
            Exam.CreateQuestions();
        }
    }
}
