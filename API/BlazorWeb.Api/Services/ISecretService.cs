using BlazorWeb.Shared.Domain.Requests;
using BlazorWeb.Shared.Domain.Responses;

namespace BlazorWeb.Api.Services
{
    public interface ISecretService
    {
        Task<SecretResponse?> GetSecretByEmployeeNameAsync(GetEmployeeSecretRequest request);
    }
}
