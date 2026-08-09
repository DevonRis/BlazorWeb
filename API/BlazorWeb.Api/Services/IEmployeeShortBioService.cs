using BlazorWeb.Shared.Domain.Requests;
using BlazorWeb.Shared.Domain.Responses;

namespace BlazorWeb.Api.Services
{
    public interface IEmployeeShortBioService
    {
        Task<EmployeeBioResponse?> GetEmployeeBioAsync(GetEmployeeBioRequest request);
    }
}
