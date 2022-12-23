using System;

namespace Decorator
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public Person(int id, string name, DateTime dOB)
        {
            Id = id;
            Name = name;
            DOB = dOB;
        }
    }
}
