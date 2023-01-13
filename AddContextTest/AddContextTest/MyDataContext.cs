using System.Text.Json.Serialization;

namespace AddContextTest
{
    [JsonSerializable(typeof(MyData))]
    public sealed partial class MyDataContext : JsonSerializerContext
    {
    }
}
