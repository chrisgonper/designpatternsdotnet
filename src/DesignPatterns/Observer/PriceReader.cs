using System;
using System.Collections.Generic;

namespace Observer
{
    internal class PriceReader : IObservable<decimal>
    {
        private decimal _currentPrice;
        private List<IObserver<decimal>> _observers = new List<IObserver<decimal>>();
        public void ReadCurrentPrice()
        {
            _currentPrice = new Random().Next(0, 50000);
            NotifyObservers();
        }
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Notify(_currentPrice);
            }
        }

        public void Subscribe(IObserver<decimal> observer)
        {
            Console.WriteLine($"{observer.GetType().Name} subscribed");
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver<decimal> observer)
        {
            Console.WriteLine($"{observer.GetType().Name} unsubscribed");
            _observers.Remove(observer);
        }
    }
}
