using BlazorWeb.Api.Repositories;
using BlazorWeb.Shared.Domain.Requests;
using BlazorWeb.Shared.Domain.Responses;

namespace BlazorWeb.Api.Services
{
    public class EmployeeShortBioService : IEmployeeShortBioService
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeShortBioService(IEmployeeRepository repository) => _repository = repository;

        public async Task<EmployeeBioResponse?> GetEmployeeBioAsync(GetEmployeeBioRequest request)
        {
            EmployeeBioResponse response = new();
            string? bio = await _repository.GetShortBioByIdAsync(request);

            if (string.IsNullOrEmpty(bio))
                response.Message = "Data could not be found";

            response.shortBio = bio;
            return response;
        }
    }
}
