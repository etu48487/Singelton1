using System;

namespace AbstractFactory
{
    public class MathFactory  IFactoryInterface
    {
        public ExamFactory CreateExam()
        {
            MathExam exam = new MathExam();
             TODO Auto-generated method stub
            return exam;
        }
    }
}