using BlazorWeb.Shared.Domain.Responses;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemShowcase.Components.Pages.Employees.PartialViews
{
    public partial class EmployeeInfo : ComponentBase
    {
        public EmployeeBioResponse? Bio { get; set; }
        private bool IsVisible { get; set; }
        public void Show(EmployeeBioResponse? bio)
        {
            Bio = bio;
            IsVisible = true;
            StateHasChanged();
        }
        public void Hide()
        {
            IsVisible = false;
            StateHasChanged();
        }
        private void CloseModal()
        {
            IsVisible = false;
        }
    }
}
