using System;
using System.Collections.Generic;
using System.Linq;

namespace Decorator
{
    internal class LimitDecorator : IPersonReader
    {
        private readonly IPersonReader _personReader;
        private readonly int _countLimit;

        public LimitDecorator(IPersonReader personReader, int limit)
        {
            this._personReader = personReader;
            this._countLimit = limit;
        }
        public IEnumerable<Person> Read()
        {
            Console.WriteLine($"Limiting the count to {_countLimit} elements");
            var people = _personReader.Read();
            return people.Take(_countLimit);
        }
    }
}
