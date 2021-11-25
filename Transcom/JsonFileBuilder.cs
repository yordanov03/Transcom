using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace Transcom
{
    public class JsonFileBuilder
    {
        public void CreateJsonFile<T>(IEnumerable<T> collection, string numberOfTram)
        {
            using (StreamWriter file = File.CreateText(@$"C:\Users\sveto\source\repos\Transcom\Transcom\Output\{numberOfTram}.json"))
            {
                var serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, collection);
            }
        }
    }
}
