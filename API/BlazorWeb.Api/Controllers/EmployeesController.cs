using BlazorWeb.Api.Services;
using BlazorWeb.Shared.Domain.Requests;
using BlazorWeb.Shared.Domain.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWeb.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly ISecretService _secretService;
        public EmployeesController(IEmployeeService employeeService, ISecretService secretService)
        {
            _employeeService = employeeService;
            _secretService = secretService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeResponse>>> Get() => Ok(await _employeeService.GetAllAsync());

        [HttpGet("secret")]
        public async Task<ActionResult<SecretResponse>> GetSecret([FromQuery] GetEmployeeSecretRequest request)
        {
            SecretResponse? secret = await _secretService.GetSecretByEmployeeNameAsync(request);
            if (secret is null) return NotFound();
            return Ok(secret);
        }
    }
}
