using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace NisreSerializer.Nisre.System.Text.Json
{
    public static class Serializer
    {
        
        private static JsonSerializerOptions o = new JsonSerializerOptions()
        {
            IgnoreNullValues = true,
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
        public static string SystemTextJsonToJson(this  object data)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(data, o);
        }
        
        public static string SystemTextJsonToJson(this  object data, JsonSerializerOptions options)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(data, options);
        }
        
        public static async Task<byte[]> SystemTextJsonToJsonByte<T>(this T data)
        {
            using (var ms = new MemoryStream())
            {
                await global::System.Text.Json.JsonSerializer.SerializeAsync<T>(ms,data,o);
                return ms.ToArray();
                
            }
        }
        
        
        public static async Task<byte[]> SystemTextJsonToJsonByte<T>(this T data,JsonSerializerOptions options)
        {
            using (var ms = new MemoryStream())
            {
                await global::System.Text.Json.JsonSerializer.SerializeAsync<T>(ms,data,options);
                return ms.ToArray();
                
            }
        }

        public static T SystemTextJsonDeserialize<T>(this string data)
        {

            return global::System.Text.Json.JsonSerializer.Deserialize<T>(data, o);

        }
        
        public static T SystemTextJsonDeserialize<T>(this string data, JsonSerializerOptions options)
        {

            return global::System.Text.Json.JsonSerializer.Deserialize<T>(data, options);
        }
        
        
        public static T SystemTextJsonDeserialize<T>(this byte[] data)
        {

            return global::System.Text.Json.JsonSerializer.Deserialize<T>(data,o);
            
        }
        
        
        public static T SystemTextJsonDeserialize<T>(this byte[] data, JsonSerializerOptions options)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<T>(data, options);
        }
        
        public static async Task<T> SystemTextJsonDeserialize<T>(this Stream stream)
        {
            return await global::System.Text.Json.JsonSerializer.DeserializeAsync<T>(stream,o);
        }
        
        public static async Task<T> SystemTextJsonDeserialize<T>(this Stream stream, JsonSerializerOptions options)
        {
            return await global::System.Text.Json.JsonSerializer.DeserializeAsync<T>(stream,options);
        }
        
        
    }
}
