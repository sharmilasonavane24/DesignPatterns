using System;
using System.Collections.Generic;

namespace ObserverDesignPattern
{
    public class StockGrabber:ISubject
    {
        private readonly List<IObserver> _observers;

        private double _ibmPrice;
        private double _applePrice;
        private double _googlePrice;

        public StockGrabber()
        {
            _observers=new List<IObserver>();
        }
        public void Register(IObserver newObserver)
        {
            _observers.Add(newObserver);
        }
        

        public void UnRegister(IObserver deleteObserver)
        {
            var observerIndex = _observers.IndexOf(deleteObserver);
            Console.WriteLine("Observer {0} deleted",observerIndex+1);
            _observers.Remove(deleteObserver);
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_ibmPrice,_applePrice,_googlePrice);
            }
        }

        public void SetIbmPrice(double newIbmPrice)
        {
            _ibmPrice = newIbmPrice;
            NotifyObserver();
        }

        public void SetApplePrice(double newApplePrice)
        {
            _applePrice = newApplePrice;
            NotifyObserver();
        }

        public void SetGooglePrice(double newGooglePrice)
        {
            _googlePrice = newGooglePrice;
            NotifyObserver();
        }
    }
}