using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StockGrabber stockGrabber=new StockGrabber();
            StockObserver observer1=new StockObserver(stockGrabber);

            stockGrabber.SetIbmPrice(1);
            stockGrabber.SetApplePrice(2);
            stockGrabber.SetGooglePrice(3);

            StockObserver observer2 = new StockObserver(stockGrabber);


            stockGrabber.SetIbmPrice(11);
            stockGrabber.SetApplePrice(12);
            stockGrabber.SetGooglePrice(13);

            stockGrabber.UnRegister(observer1);

            stockGrabber.SetIbmPrice(11);
            stockGrabber.SetApplePrice(12);
            stockGrabber.SetGooglePrice(13);

        }
    }
}
