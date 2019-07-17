using System;

namespace ObserverDesignPattern
{
    public class StockObserver : IObserver
    {
        private double _ibmPrice;
        private double _applePrice;
        private double _googlePrice;

        private static int _observerIdTracker = 0;
        private readonly int _observerId;

        private ISubject _stockGrabber;

        public StockObserver(ISubject stockGrabber)
        {
            _stockGrabber = stockGrabber;
            _observerId = ++_observerIdTracker;
            Console.WriteLine("New Observer {0}", _observerId);

            stockGrabber.Register(this);
        }

        public void Update(double ibmPrice, double applePrice, double googleProce)
        {
            _ibmPrice = ibmPrice;
            _applePrice = applePrice;
            _googlePrice = googleProce;

            PrintPrice();
        }

        public void PrintPrice()
        {
            Console.WriteLine($"{_observerId} IBM: {_ibmPrice} Apple: {_applePrice} Google: {_googlePrice}");
        }
    }
}