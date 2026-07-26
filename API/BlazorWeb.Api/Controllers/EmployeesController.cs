using BlazorWeb.Shared.Domain.Responses;
using BlazorWeb.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWeb.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService) => _employeeService = employeeService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeResponse>>> Get() => Ok(await _employeeService.GetAllAsync());
    }
}
