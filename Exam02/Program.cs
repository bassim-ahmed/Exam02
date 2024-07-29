using System.Diagnostics;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject()
            {
                Id = 1,
                Name = "c#",
            };

            subject.CreateExam();
            Console.Clear();

            Console.WriteLine("Do You Want To Start Exam (Y|N)");


            if (char.Parse(Console.ReadLine()) == 'Y')
            {
                Console.Clear();

                Stopwatch sw = new Stopwatch();

                sw.Start();

                subject.Exam.ShowExam();

                Console.WriteLine($"Time = {sw.Elapsed}");
            }

            Console.WriteLine("Good Luck");
        }
    }
}
