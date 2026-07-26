using BlazorWeb.Shared.Domain.Requests;
using BlazorWeb.Shared.Domain.Responses;
using BlazorWebAssemShowcase.Pages.PartialViews;
using BlazorWebAssemShowcase.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemShowcase.Pages.Employees
{
    public partial class EmployeeDisplay : ComponentBase
    {
        [Inject]
        private IEmployeeService EmployeeService { get; set; } = default!;
        private List<EmployeeResponse>? Employees { get; set; }
        private SecretResponse? SelectedSecret { get; set; }
        private EmployeeSecretsPopUpModal? employeeSecretsModal;
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
