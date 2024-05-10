namespace TangoRestApiClient.Common.Config;

public class TangoConfig : ITangoConfig
{
    public string TangoUrl { get; set; } = "";
    public string ApiAuthorization { get; set; } = "";
    public string CompanyId { get; set; } = "";
}