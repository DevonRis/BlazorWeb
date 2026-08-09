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
        private readonly IEmployeeShortBioService _employeeShortBioService;
        public EmployeesController(IEmployeeService employeeService, ISecretService secretService, IEmployeeShortBioService employeeShortBioService)
        {
            _employeeService = employeeService;
            _secretService = secretService;
            _employeeShortBioService = employeeShortBioService;
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
        [HttpGet("bio")]
        public async Task<ActionResult<EmployeeBioResponse>> GetEmployeeBio([FromQuery] GetEmployeeBioRequest request)
        {
            EmployeeBioResponse? bio = await _employeeShortBioService.GetEmployeeBioAsync(request);
            if (bio is null) return NotFound();
            return Ok(bio);
        }
    }
}
