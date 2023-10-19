using System;

namespace AbstractFactory
{
    public class MathExam : IExamFactory
    {
        public void Conduct()
        {
            // Output: "Conducting Math Exam", should use Printer class to print the message
            Printer printer = Printer.GetPrinter(1);
            string message = "Conducting Math Exam";
            printer.Print(message);
        }

        public void Evaluate()
        {
            // Output: "Evaluating Math Exam", should use Printer class to print the message
            Printer printer = Printer.GetPrinter(1);
            string message = "Evaluating Math Exam";
            printer.Print(message);
        }

        public void PublishResults()
        {
            // Output: "Publishing Math Exam Results", should use Printer class to print the message
            Printer printer = Printer.GetPrinter(1);
            string message = "Publishing Math Exam Results";
            printer.Print(message);
        }
    }
}