using System.Threading.Tasks;

namespace Warners.Common.Serialization
{
    public interface ISerializer
    {
        Task<string> SerializeAsync(object element);
        Task<T> DeserializeAsync<T>(string element);
    }
}
