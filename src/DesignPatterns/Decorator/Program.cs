using System;
using System.Collections.Generic;

namespace Decorator
{
    internal class Program
    {
        public static int defaultNum = 0;
        static void Main(string[] args)
        {
            IPersonReader loggingLimitReader = new LoggingDecorator(
                                                    new LimitDecorator(
                                                        new PersonReader(), 3), new ConsoleLogger());
            //var people = loggingLimitReader.Read();

            IPersonReader loggingReader = new LoggingDecorator(new PersonReader(), new ConsoleLogger());

            //var people = loggingReader.Read();

            IPersonReader limitedReader = new LimitDecorator(new PersonReader(), 1);

            //var people = limitedReader.Read();

            IPersonReader personReader = new PersonReader();

            var people = personReader.Read();
            
            PrintResult(people);
            //test comment for ammend

            Console.ReadKey();
        }

        public static void PrintResult(IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} was born on {person.DOB:MMM dd, yyyy}");
            }
        }
        public static int GetNumberA(string value)
        {
            return int.Parse(value);
        }
    }
}
