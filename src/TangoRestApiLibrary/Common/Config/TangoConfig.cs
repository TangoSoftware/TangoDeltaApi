namespace TangoRestApiClient.Common.Config;

public class TangoConfig : ITangoConfig
{
    public required string TangoUrl { get; set; }
    public required string ApiAuthorization { get; set; }
    public required string CompanyId { get; set; }
}
