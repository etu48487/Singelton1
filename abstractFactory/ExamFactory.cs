using System;

namespace AbstractFactory
{
    public interface IExamFactory
    {
        void Conduct();
        void Evaluate();
        void PublishResults();
    }
}