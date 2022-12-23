using System;

namespace Observer
{
    internal class SmsNotifier : IObserver<decimal>
    {
        private readonly decimal priceThreshold;

        public SmsNotifier(decimal threshold)
        {
            this.priceThreshold = threshold;
        }

        public void Notify(decimal price)
        {
            if (price > priceThreshold)
            {
                Console.WriteLine($"simulating SMS notification. current price {price} is greater than {priceThreshold}");
            }
        }
    }
}
