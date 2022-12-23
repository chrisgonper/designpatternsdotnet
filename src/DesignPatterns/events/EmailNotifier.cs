using System;

namespace events
{
    internal class EmailNotifier
    {
        private readonly decimal priceThreshold;

        public EmailNotifier(decimal threshold)
        {
            this.priceThreshold = threshold;
        }

        public void Notify(decimal price)
        {
            if (price > priceThreshold)
            {
                Console.WriteLine($"simulating email notification. current price {price} is greater than { priceThreshold}");
            }
        }
    }
}
