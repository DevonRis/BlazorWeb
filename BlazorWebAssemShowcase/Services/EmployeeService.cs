using BlazorWeb.Shared.Domain.Responses;
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
    }
}
