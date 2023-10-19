using System;
using AbstractFactory;
public class Main
{
    public static void Main(string[] args)
    {
        Printer printer = Printer.GetPrinter(0);
        printer.Print("test");
        Printer printer2 = Printer.GetPrinter(1);
        printer.GetSerialNumber();
        printer2.GetSerialNumber();
        try
        {
            Console.WriteLine("Which matter? (1=Science, 2=Math, 3=Programming)");
            int result = Convert.ToInt32(Console.ReadLine());
            FactoryInterface matter;
            if (result == 1)
            {
                matter = new ScienceFactory();
            }
            else if (result == 2)
            {
                matter = new MathFactory();
            }
            else
            {
                matter = new ProgrammingFactory();
            }
            Course course = new Course(matter);
            ExamFactory exam = course.GetExam();
            exam.Conduct();
            exam.Evaluate();
            exam.PublishResults();
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input");
        }
    }
}