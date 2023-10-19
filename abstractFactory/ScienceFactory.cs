using System;

namespace abstractFactory
{
    public class ScienceFactory : FactoryInterface
    {
        public ExamFactory CreateExam()
        {
            // TODO Auto-generated method stub
            ScienceExam exam = new ScienceExam();
            return exam;
        }
    }
}