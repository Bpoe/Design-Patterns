namespace ObserverPattern
{
    public interface IObserver
    {
        void Update();
    }

    public interface ISubject
    {
        void RegisterObserver(IObserver observer);

        void UnregisterObserver(IObserver observer);

        void NotifyObservers();
    }
}
