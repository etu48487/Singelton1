using System;

namespace AbstractFactory
{
    public interface IFactoryInterface
    {
        IExamFactory CreateExam();
    }
}