namespace NisreSerializer.Nisre.ServiceStack.Text
{
    public static class Serializer
    {
       
        
        public static string ServiceStackToJson(this  object data)
        {
            return global::ServiceStack.Text.JsonSerializer.SerializeToString(data);
        }


        public static T ServiceStackDeserialize<T>(this string data)
        {
            return global::ServiceStack.Text.JsonSerializer.DeserializeFromString<T>(data);
        }
        
        
    }
}
