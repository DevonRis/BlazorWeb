using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using BlazorWeb.Shared.Domain.Requests;
using BlazorWeb.Shared.Domain.Responses;

namespace BlazorWeb.Api.Services
{
    public class SecretService : ISecretService
    {
        private readonly SecretClient _secretClient;
        public SecretService(IConfiguration configuration)
        {
            var vaultUri = configuration["KeyVault:Uri"];

            _secretClient = new SecretClient(new Uri(vaultUri!), new DefaultAzureCredential());
        }

        public async Task<SecretResponse?> GetSecretByEmployeeNameAsync(GetEmployeeSecretRequest request)
        {
            // Build the vault secret name to match what's stored in Azure vault: "SecretKey-DevonRismay"
            var secretName = $"SecretKey-{request.FirstName}{request.LastName}";

            try
            {
                var secret = await _secretClient.GetSecretAsync(secretName);
                return new SecretResponse
                {
                    SecretKey = secret.Value.Value
                };
            }
            catch (Azure.RequestFailedException)
            {
                return new SecretResponse
                {
                    SecretKey = null,
                    Message = "Secret not found in the key vault."
                };
            }
        }
    }
}
