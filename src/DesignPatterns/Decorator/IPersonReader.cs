using System.Collections.Generic;

namespace Decorator
{
    internal interface IPersonReader
    {
        IEnumerable<Person> Read();
    }
}
