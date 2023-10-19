using System;

namespace AbstractFactory
{
    public class ScienceExam : ExamFactory
    {
        public override void Conduct()
        {
            Printer printer = Printer.GetPrinter(1);
            string message = "Conducting Science Exam";
            printer.Print(message);
        }

        public override void Evaluate()
        {
            Printer printer = Printer.GetPrinter(1);
            string message = "Evaluating Science Exam";
            printer.Print(message);
        }

        public override void PublishResults()
        {
            Printer printer = Printer.GetPrinter(1);
            string message = "Publishing Science Exam Results";
            printer.Print(message);
        }
    }
}