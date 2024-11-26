using System.Text.Json.Serialization;

namespace EditorJs.Models;

/// <summary>
/// The definition of an editor js configuration object
/// </summary>
public interface IEditorJsConfiguration
{
    /// <summary>
    /// The holder ID of the element hosting the editor
    /// </summary>
    [JsonPropertyName("holderId")]
    public string? Id { get; set; }
    
    /// <summary>
    /// A json object representing the tools that should be loaded (optional)
    /// </summary>
    [JsonPropertyName("tools")]
    public JsonObject? Tools { get; set; }
    
    /// <summary>
    /// A json object representing the data that should be displayed in the editor (optional)
    /// </summary>
    [JsonPropertyName("data")]
    public JsonObject? Data { get; set; }
    
    /// <summary>
    /// A callback whenever the editor saves changes
    /// </summary>
    [JsonIgnore]
    public EventCallback<JsonObject> OnSave { get; set; }
    
    /// <summary>
    /// A callback for when the editor finishes its first-time load
    /// </summary>
    [JsonIgnore]
    public EventCallback OnLoad { get; set; }
    
    /// <summary>
    /// A callback for when the editor encounters an error
    /// </summary>
    [JsonIgnore]
    public EventCallback<JsonObject> OnError { get; set; }
    
    /// <summary>
    /// The default block
    /// </summary>
    [JsonPropertyName("defaultBlock")]
    public string DefaultBlock { get; set; }
    
    /// <summary>
    /// Whether the editor should automatically receive focus or not
    /// </summary>
    [JsonPropertyName("autofocus")]
    public bool AutoFocus { get; set; }
    
    /// <summary>
    /// A placeholder for when the editor contains no content
    /// </summary>
    [JsonPropertyName("placeholder")]
    public string PlaceHolder { get; set; }
    
    /// <summary>
    /// The loglevel that should be reported. Please use values from Models/LogLevel.cs
    /// </summary>
    [JsonPropertyName("logLevel")]
    public string LogLevel { get; set; }
    
    /// <summary>
    /// Whether the editor should be set to read only
    /// </summary>
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }
}
