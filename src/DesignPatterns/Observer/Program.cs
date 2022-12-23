using System;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailNOtifier = new EmailNotifier(20000);
            var smsNotifier = new SmsNotifier(30000);
            var priceReader = new PriceReader();
            priceReader.Subscribe(emailNOtifier);
            priceReader.Subscribe(smsNotifier);

            priceReader.ReadCurrentPrice();
            priceReader.ReadCurrentPrice();
            priceReader.ReadCurrentPrice();

            priceReader.Unsubscribe(emailNOtifier);

            priceReader.ReadCurrentPrice();
            priceReader.ReadCurrentPrice();


            Console.ReadKey();
        }
    }
}
