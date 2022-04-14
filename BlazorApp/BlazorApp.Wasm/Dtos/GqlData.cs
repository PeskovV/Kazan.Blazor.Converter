using System.Text.Json.Serialization;

namespace BlazorApp.Wasm.Dtos;

public class GqlData
{
    [JsonPropertyName("data")]
    public Data Data { get; set; }
}

public class Data
{
    [JsonPropertyName("launches")]
    public LaunchDto[]? Launches { get; set; }
}