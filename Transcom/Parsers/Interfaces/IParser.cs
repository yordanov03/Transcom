using System.Collections.Generic;

namespace Transcom.Parsers
{
    public interface IParser<T> where T : class
    {
        List<T> ParseInput(string[] input, string[] additionalArguments);
    }
}
