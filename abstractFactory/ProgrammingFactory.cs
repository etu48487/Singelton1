using System;

namespace abstractFactory
{
    public class ProgrammingFactory : FactoryInterface
    {
        public ExamFactory CreateExam()
        {
            // TODO Auto-generated method stub
            ProgrammingExam exam = new ProgrammingExam();
            return exam;
        }
    }
}