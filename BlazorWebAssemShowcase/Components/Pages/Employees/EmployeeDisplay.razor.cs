using BlazorWeb.Shared.Domain.Requests;
using BlazorWeb.Shared.Domain.Responses;
using BlazorWebAssemShowcase.Services;
using Microsoft.AspNetCore.Components;
using BlazorWebAssemShowcase.Components.Pages.Employees.PartialViews;

namespace BlazorWebAssemShowcase.Components.Pages.Employees
{
    public partial class EmployeeDisplay : ComponentBase
    {
        [Inject]
        private IEmployeeService EmployeeService { get; set; } = default!;
        private List<EmployeeResponse>? Employees { get; set; }
        private SecretResponse? SelectedSecret { get; set; }
        private EmployeeSecretsPopUpModal? employeeSecretsModal;

        private string SelectedDepartment { get; set; } = "";

        // filter runs off the bound dropdown; empty = show everyone
        private IEnumerable<EmployeeResponse> FilteredEmployees =>
            Employees == null
                ? Enumerable.Empty<EmployeeResponse>()
                : string.IsNullOrEmpty(SelectedDepartment)
                    ? Employees
                    : Employees.Where(e => e.Department.ToString() == SelectedDepartment);
        protected async override Task OnInitializedAsync()
        {
            await GetApiEmployeesForView();
        }
        private async Task GetApiEmployeesForView()
        {
            Employees = await EmployeeService.GetEmployeesAsync();
        }
        private async Task ShowEmployeeSecretsModal(string firstName, string lastName)
        {
            GetEmployeeSecretRequest request = new();
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                request = new GetEmployeeSecretRequest { FirstName = firstName, LastName = lastName };
            }

            SelectedSecret = await EmployeeService.GetEmployeeSecretAsync(request);
            employeeSecretsModal?.Show(SelectedSecret);
        }
    }
}
