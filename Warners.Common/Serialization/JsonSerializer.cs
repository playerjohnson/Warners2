using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warners.Common.Serialization
{
    public class JsonSerializer : ISerializer
    {
        public Task<T> DeserializeAsync<T>(string element)
            => Task.FromResult(result: JsonConvert.DeserializeObject<T>(element));

        public Task<string> SerializeAsync(object element)
            => Task.FromResult(result: JsonConvert.SerializeObject(element));
    }
}
