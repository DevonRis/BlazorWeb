using BlazorWeb.Shared.Domain.Responses;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemShowcase.Pages.PartialViews
{
    public partial class EmployeeSecretsPopUpModal : ComponentBase
    {
        [Parameter]
        public SecretResponse? Secret { get; set; }
        private bool IsVisible { get; set; }

        public void Show(SecretResponse? secret)
        {
            Secret = secret;
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
