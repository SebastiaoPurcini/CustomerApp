using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomerApp.Core.Services.JsonConverter
{
    public static class JsonConverter
    {
        private static JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public static async Task<List<T>> GetJsonToObjectList<T>(string content)
        {
            var list = JsonSerializer.Deserialize<List<T>>(content, options);

            return await Task.Run(() => list);
        }
    }
}
