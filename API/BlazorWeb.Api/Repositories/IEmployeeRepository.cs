using BlazorWeb.Api.Models;
using BlazorWeb.Shared.Domain.Requests;

namespace BlazorWeb.Api.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
        Task<string?> GetShortBioByIdAsync(GetEmployeeBioRequest request);
    }
}
