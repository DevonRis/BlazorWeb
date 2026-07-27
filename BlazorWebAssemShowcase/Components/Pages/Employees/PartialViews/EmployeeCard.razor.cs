using BlazorWeb.Shared.Domain.Responses;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemShowcase.Components.Pages.Employees.PartialViews
{
    public partial class EmployeeCard : ComponentBase
    {
        [Parameter, EditorRequired]
        public EmployeeResponse Employee { get; set; } = default!;

        [Parameter]
        public EventCallback OnInfoClicked { get; set; }
        [Parameter]
        public EventCallback OnSecretKeyClicked { get; set; }

        // initials fallback for when an employee has no ImageUrl
        private string GetInitials()
        {
            var first = string.IsNullOrEmpty(Employee.FirstName) ? "" : Employee.FirstName![..1];
            var last = string.IsNullOrEmpty(Employee.LastName) ? "" : Employee.LastName![..1];
            return $"{first}{last}".ToUpper();
        }
    }
}
