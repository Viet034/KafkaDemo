using System.Text.Json;
using System.Text.Json.Serialization;

namespace connectOracleDBTest.Ultilites;

public class JsonConvertera : JsonConverter<string>
{
    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType == JsonTokenType.Number
            ? reader.GetInt64().ToString()
            : reader.GetString();
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}
