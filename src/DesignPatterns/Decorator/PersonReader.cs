using System;
using System.Collections.Generic;

namespace Decorator
{
    internal class PersonReader : IPersonReader
    {
        public IEnumerable<Person> Read()
        {
            return new List<Person>()
            {
                new Person(1, "Christian Gonzalez", new DateTime(1991, 9, 12)),
                new Person(2, "Fernanda Perez", new DateTime(1998, 3, 14)),
                new Person(3, "Yareni GP", new DateTime(2022, 10, 1)),
                new Person(3, "Chofis Gonzalez", new DateTime(2016, 6, 13)),
                new Person(3, "Darius Santiago", new DateTime(2019, 8, 13))
            };
        }
    }
}
