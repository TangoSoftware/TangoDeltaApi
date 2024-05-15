using Newtonsoft.Json;

namespace TangoRestApiLibrary.services.basemodel;
public abstract class BaseQuery<D, QR> where D : BaseResultData<QR> where QR : BaseQueryRecord
{
    [JsonProperty("resultData")]
    public D? ResultData { get; set; }

    [JsonProperty("message")]
    public object Message { get; set; }

    [JsonProperty("exceptionInfo")]
    public object ExceptionInfo { get; set; }

    [JsonProperty("succeeded")]
    public bool Succeeded { get; set; }
}

public abstract class BaseResultData<QR> where QR : BaseQueryRecord
{
    [JsonProperty("list")]
    public QR[]? List { get; set; }

    [JsonProperty("pageIndex")]
    public int PageIndex { get; set; }

    [JsonProperty("pageSize")]
    public int PageSize { get; set; }

    [JsonProperty("totalCount")]
    public int TotalCount { get; set; }

    [JsonProperty("totalPages")]
    public int TotalPages { get; set; }

    [JsonProperty("hasPreviousPage")]
    public bool HasPreviousPage { get; set; }

    [JsonProperty("hasNextPage")]
    public bool HasNextPage { get; set; }
}

public abstract class BaseQueryRecord
{
    public abstract int GetId();
}