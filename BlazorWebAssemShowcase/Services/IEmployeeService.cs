using BlazorWeb.Shared.Domain.Responses;
using BlazorWeb.Shared.Domain.Requests;

namespace BlazorWebAssemShowcase.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeResponse>?> GetEmployeesAsync();
        Task<SecretResponse?> GetEmployeeSecretAsync(GetEmployeeSecretRequest request);
    }
}
