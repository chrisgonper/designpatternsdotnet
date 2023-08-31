using System;

namespace Decorator
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public Person(int id, string name, DateTime dOB, string address)
        {
            Id = id;
            Name = name;
            DOB = dOB;
            Address = address;
        }
        public override string ToString()
        {
            return $"{Id} - {Name} - {DOB:dd/mm/yy}";
        }
    }
}
