namespace TestApi.services
{
    public static class AmazonSecretsManagerExtensions
    {
        public static IConfigurationBuilder AddAmazonSecretsManager(this IConfigurationBuilder configurationBuilder, IConfiguration configuration)
        {
            var secretName = configuration["SecretApiKey"]; // Fetch directly from appsettings.json

            if (!string.IsNullOrEmpty(secretName))
            {
                var region = "ap-south-1"; // Hardcoded or configured elsewhere
                var configurationSource = new AmazonSecretsManagerConfigurationSource(region, secretName);
                configurationBuilder.Add(configurationSource);
            }

            return configurationBuilder;
        }
    }
}
