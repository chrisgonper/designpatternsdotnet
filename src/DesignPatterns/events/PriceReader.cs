using System;

namespace events
{
    public delegate void PriceRead(decimal price);
    public class PriceReader
    {
        private decimal _currentPrice;
        public event PriceRead PriceRead;

        public void ReadCurrentPrice()
        {
            _currentPrice = new Random().Next(0, 50000);
            OnPriceRead(_currentPrice);
        }

        private void OnPriceRead(decimal currentPrice)
        {
            PriceRead.Invoke(currentPrice);
        }
    }
}
