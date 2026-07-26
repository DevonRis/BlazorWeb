using BlazorWeb.Shared.Domain.Responses;
using BlazorWeb.Shared.Domain.Requests;
using System.Net.Http.Json;

namespace BlazorWebAssemShowcase.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient) => _httpClient = httpClient;
        public async Task<List<EmployeeResponse>?> GetEmployeesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<EmployeeResponse>?>("api/Employees");
        }
        public async Task<SecretResponse?> GetEmployeeSecretAsync(GetEmployeeSecretRequest request)
            => await _httpClient.GetFromJsonAsync<SecretResponse?>(
                   $"api/Employees/secret?firstName={request.FirstName}&lastName={request.LastName}");
    }
}
