using Newtonsoft.Json;

namespace TangoDeltaApi.Core.Service;

public class TransactionException(string message, ExceptionInfo exceptionInfo) : Exception(message)
{
    public readonly ExceptionInfo exceptionInfo = exceptionInfo;
}

public class TransactionResultModel
{
    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("exceptionInfo")]
    public ExceptionInfo? ExceptionInfo { get; set; }

    [JsonProperty("succeeded")]
    public bool Succeeded { get; set; }

    [JsonProperty("savedId")]
    public int SavedId { get; set; }
}

public class ExceptionInfo
{
    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("messages")]
    public string[]? Messages { get; set; }

    [JsonProperty("detailMessages")]
    public string[]? DetailMessages { get; set; }
}
