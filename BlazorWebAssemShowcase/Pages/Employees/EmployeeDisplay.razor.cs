using BlazorWeb.Shared.Domain.Responses;
using BlazorWebAssemShowcase.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemShowcase.Pages.Employees
{
    public partial class EmployeeDisplay : ComponentBase
    {
        [Inject]
        private IEmployeeService EmployeeService { get; set; } = default!;
        private List<EmployeeResponse>? Employees { get; set; }
        protected async override Task OnInitializedAsync()
        {
            await GetApiEmployeesForView();
        }
        private async Task GetApiEmployeesForView()
        {
            Employees = await EmployeeService.GetEmployeesAsync();
        }
    }
}
