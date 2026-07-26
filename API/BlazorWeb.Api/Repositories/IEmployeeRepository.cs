using BlazorWeb.Api.Models;

namespace BlazorWeb.Api.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
    }
}
