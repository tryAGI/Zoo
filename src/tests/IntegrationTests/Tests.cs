namespace Zoo.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ZooClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ZOO_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("ZOO_API_KEY environment variable is not found.");

        var client = new ZooClient(apiKey);
        
        return client;
    }
}
