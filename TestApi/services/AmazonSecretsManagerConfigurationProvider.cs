using Amazon;
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
namespace TestApi.services
{
    public class AmazonSecretsManagerConfigurationProvider : ConfigurationProvider
    {
        private readonly string _region;
        private readonly string _secretName;

        public AmazonSecretsManagerConfigurationProvider(string region, string secretName)
        {
            _region = region;
            _secretName = secretName;
        }

        public override void Load()
        {
            var secret = GetSecret();
            if (!string.IsNullOrEmpty(secret))
            {
                Data = JsonSerializer.Deserialize<Dictionary<string, string>>(secret);
            }
        }

        private string GetSecret()
        {
            using var client = new AmazonSecretsManagerClient(RegionEndpoint.GetBySystemName(_region));

            var request = new GetSecretValueRequest
            {
                SecretId = _secretName,
                VersionStage = "AWSCURRENT"
            };

            var response = client.GetSecretValueAsync(request).Result;
            return response.SecretString ??
                   System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(response.SecretBinary.ToString()));
        }
    }
}