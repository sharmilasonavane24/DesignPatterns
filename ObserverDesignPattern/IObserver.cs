namespace ObserverDesignPattern
{
    public interface IObserver
    {
        void Update(double ibmPrice, double applePrice, double googleProce);
    }
}