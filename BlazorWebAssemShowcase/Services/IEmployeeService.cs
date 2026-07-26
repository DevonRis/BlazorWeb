using BlazorWeb.Shared.Domain.Responses;

namespace BlazorWebAssemShowcase.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeResponse>?> GetEmployeesAsync();
    }
}
