using System.Collections.Generic;
using System.Linq;

namespace Decorator
{
    internal class LoggingDecorator : IPersonReader
    {
        private readonly IPersonReader _personReader;
        private readonly ILogger _logger;

        public LoggingDecorator(IPersonReader personReader, ILogger logger)
        {
            this._personReader = personReader;
            this._logger = logger;
        }
        public IEnumerable<Person> Read()
        {
            var people = _personReader.Read();
            _logger.Log($"People list has {people.Count()} elements");
            return people;
        }
    }
}
