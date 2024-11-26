using System.Text.Json.Serialization;

namespace EditorJs.Models;

public class DefaultEditorJsConfiguration : IEditorJsConfiguration
{
    [JsonPropertyName("holderId")]
    public string? Id { get; set; }
    
    [JsonPropertyName("tools")]
    public JsonObject? Tools { get; set; }
    
    [JsonPropertyName("data")]
    public JsonObject? Data { get; set; }
    
    [JsonIgnore]
    public EventCallback<JsonObject> OnSave { get; set; }
    
    [JsonIgnore]
    public EventCallback OnLoad { get; set; }
    
    [JsonIgnore]
    public EventCallback<JsonObject> OnError { get; set; }
    
    [JsonPropertyName("defaultBlock")]
    public required string DefaultBlock { get; set; }
    
    [JsonPropertyName("autofocus")]
    public bool AutoFocus { get; set; }
    
    [JsonPropertyName("placeholder")]
    public required string PlaceHolder { get; set; }
    
    [JsonPropertyName("logLevel")]
    public string LogLevel { get; set; } = Models.LogLevel.Error;
    
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }
}
