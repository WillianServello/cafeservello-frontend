using Microsoft.AspNetCore.Components;

namespace cafeservello_UI.Components.Common.Button
{
    public partial class CommonButton
    {
        [Inject]
        private NavigationManager Navigation { get; set; } = default!;

        [Parameter]
        public string Text { get; set; } = "";

        [Parameter]
        public string Icon { get; set; } = "";

        [Parameter]
        public string Href { get; set; } = "";

        private void GoPage()
        {
            Navigation.NavigateTo(Href);
        }
    }
}