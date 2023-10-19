using AbstractFactory;

public class Course
{
    private FactoryInterface factory;

    public Course(FactoryInterface factory)
    {
        this.factory = factory;
    }

    public ExamFactory GetExam()
    {
        ExamFactory exam = factory.CreateExam();
        return exam;
    }
}