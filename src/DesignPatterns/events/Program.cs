﻿using System;

namespace events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var priceReader = new PriceReader();
            var emailNotifier = new EmailNotifier(40000);
            //attach de event
            priceReader.PriceRead += emailNotifier.Notify;

            priceReader.ReadCurrentPrice();
            //is a good practice to detach the event
            priceReader.PriceRead -= emailNotifier.Notify;
            //test comment
            Console.ReadKey();
        }

        private static void PriceReader_PriceRead(decimal price)
        {
            Console.WriteLine($"current price {price}");
        }
    }
    
    

}
