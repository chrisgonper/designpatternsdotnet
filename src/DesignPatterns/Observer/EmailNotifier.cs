using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class EmailNotifier : IObserver<decimal>
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
                Console.WriteLine($"simulating email notification. current price {price} is greater than {priceThreshold}");
            }
        }
    }
}
