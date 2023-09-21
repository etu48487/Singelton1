

Logger test = Logger.getLogger(1);
test.printer("test");

public class Logger
{
    private static Logger instance;

    private int instanceNumber;

    private Logger(int number)
    {
        this.instanceNumber = number;
    }

    public static Logger getLogger(int number)
    {
        if (instance == null)
        {
            instance = new Logger(number);
        }
        return instance;
    }

    public virtual void printer(string message)
    {
        System.Console.Out.WriteLine("instance : " + instanceNumber + " : " + message);
    }
}