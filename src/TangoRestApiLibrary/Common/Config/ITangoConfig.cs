namespace TangoRestApiClient.Common.Config;

public interface ITangoConfig
{
    public string TangoUrl { get; set; }
    public string ApiAuthorization { get; set; }
    public string CompanyId { get; set; }
}