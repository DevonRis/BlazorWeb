using BlazorWeb.Api.Data;
using BlazorWeb.Api.Models;
using BlazorWeb.Shared.Domain.Requests;
using Microsoft.EntityFrameworkCore;

namespace BlazorWeb.Api.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _dbContext;
        public EmployeeRepository(AppDbContext dbContext) => _dbContext = dbContext;

        public async Task<List<Employee>> GetAllAsync() => await _dbContext.Employees.ToListAsync();
        public async Task<string?> GetShortBioByIdAsync(GetEmployeeBioRequest request) => await _dbContext.Employees
                .Where(e => e.EmployeeId == request.EmployeeId)
                .Select(e => e.ShortBio)
                .FirstOrDefaultAsync();
    }
}
