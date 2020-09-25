using System.IO;
using System.Threading.Tasks;
using Jil;
using Utf8Json;
using Utf8Json.Resolvers;

namespace NisreSerializer.Nisre.Utf8Json
{
    public static class Serializer
    {


        public static string Utf8ToJson(this  object data)
        {
            return global::Utf8Json.JsonSerializer.ToJsonString(data,StandardResolver.ExcludeNullCamelCase);
        }
        
        public static string Utf8ToJson(this  object data, IJsonFormatterResolver resolver)
        {
            return global::Utf8Json.JsonSerializer.ToJsonString(data, resolver);
        }
        
        public static byte[] Utf8ToJsonByte(this  object data)
        {
            return global::Utf8Json.JsonSerializer.Serialize(data, StandardResolver.ExcludeNullCamelCase);
        }
        
        public static byte[] Utf8ToJsonByte(this  object data, IJsonFormatterResolver resolver)
        {
            return global::Utf8Json.JsonSerializer.Serialize(data, resolver);
        }
        
        public static async Task<T> Utf8JsonDeserialize<T>(this Stream data)
        {
            return await global::Utf8Json.JsonSerializer.DeserializeAsync<T>(data);
        }
        
        
    }
}
