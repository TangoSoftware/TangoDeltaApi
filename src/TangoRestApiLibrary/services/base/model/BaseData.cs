using Newtonsoft.Json;

namespace TangoRestApiLibrary.services.basemodel;

public abstract class BaseData<D> where D : BaseDataset
{
    [JsonProperty("value")]
    public D Value { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("exceptionInfo")]
    public string? ExceptionInfo { get; set; }

    [JsonProperty("succeeded")]
    public bool Succeeded { get; set; }
}

public abstract class BaseDataset
{
}
