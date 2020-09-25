using Jil;

namespace NisreSerializer.Nisre.Jil
{
    public static class Serializer
    {


        public static string JilToJson(this  object data)
        {
            return global::Jil.JSON.Serialize(data);
        }
        
        public static string JilToJson(this  object data, Options o)
        {
            return global::Jil.JSON.Serialize(data,o);
        }


        public static T JilDeserialize<T>(this string data)
        {
            return global::Jil.JSON.Deserialize<T>(data);
        }
        
        public static T JilDeserialize<T>(this string data, Options o)
        {
            return global::Jil.JSON.Deserialize<T>(data, o);
        }

        
    }
}
