using System;

namespace events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var priceReader = new PriceReader();
            var emailNotifier = new EmailNotifier(30000);
            priceReader.PriceRead += emailNotifier.Notify;

            priceReader.ReadCurrentPrice();

            priceReader.PriceRead -= PriceReader_PriceRead;

            Console.ReadKey();
        }

        private static void PriceReader_PriceRead(decimal price)
        {
            Console.WriteLine($"current price {price}");
        }
    }
    
    

}
