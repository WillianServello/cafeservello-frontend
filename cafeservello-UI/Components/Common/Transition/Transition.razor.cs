using Microsoft.AspNetCore.Components;

namespace cafeservello_UI.Components.Common.Transition;

public partial class Transition : ComponentBase, IDisposable
{
    [Inject]
    private NavigationManager Navigation { get; set; } = default!;

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    protected string CssClass = "page";

    protected override void OnInitialized()
    {
        Navigation.LocationChanged += OnLocationChanged;
    }

    private async void OnLocationChanged(object? sender, Microsoft.AspNetCore.Components.Routing.LocationChangedEventArgs e)
    {
        CssClass = "";
        await InvokeAsync(StateHasChanged);

        await Task.Delay(10);

        CssClass = "page";
        await InvokeAsync(StateHasChanged);
    }

    public void Dispose()
    {
        Navigation.LocationChanged -= OnLocationChanged;
    }
}