using System;

namespace AbstractFactory
{
    public class ProgrammingExam : IExamFactory
    {
        public void Conduct()
        {
            Printer printer = Printer.GetPrinter(1);
            string message = "Conducting Programming Exam";
            printer.Print(message);
        }

        public void Evaluate()
        {
            Printer printer = Printer.GetPrinter(1);
            string message = "Evaluating Programming Exam";
            printer.Print(message);
        }

        public void PublishResults()
        {
            Printer printer = Printer.GetPrinter(1);
            string message = "Publishing Programming Exam Results";
            printer.Print(message);
        }
    }
}