using BlazorWeb.Shared.Domain.Responses;
using BlazorWeb.Api.Mappings;
using BlazorWeb.Api.Repositories;

namespace BlazorWeb.Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeService(IEmployeeRepository repository) => _repository = repository;
        public async Task<List<EmployeeResponse>> GetAllAsync()
        {
            var employees = await _repository.GetAllAsync();
            return employees.Select(e => e.ToResponse()).ToList();
        }
    }
}
