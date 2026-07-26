using BlazorWeb.Shared.Domain.Responses;

namespace BlazorWeb.Api.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeResponse>> GetAllAsync();
        /*Task<EmployeeResponse?> GetByIdAsync(int id);
        Task<EmployeeResponse> CreateAsync(EmployeeResponse dto);
        Task<bool> UpdateAsync(EmployeeResponse dto);
        Task<bool> DeleteAsync(int id);*/
    }
}
