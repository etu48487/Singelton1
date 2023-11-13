namespace Observer
{
    public interface Subject
    {
        void RegisterObserver(Observer obs);
        void RemoveObserver(Observer obs);
        void NotifyObserver();
    }
}