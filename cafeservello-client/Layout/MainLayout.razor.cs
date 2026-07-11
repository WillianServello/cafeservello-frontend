using cafeservello_UI.Services.Common.Theme;
using cafeservello_UI.Services.Layout;
using Microsoft.AspNetCore.Components;

namespace cafeservello_client.Layout;

public partial class MainLayout : LayoutComponentBase, IDisposable
{
    [Inject]
    public ThemeService ThemeService { get; set; } = default!;

    [Inject]
    public SidebarService SidebarService { get; set; } = default!;


    protected override void OnInitialized()
    {
        ThemeService.OnChange += StateHasChanged;
        SidebarService.OnChange += StateHasChanged;
    }


    public void Dispose()
    {
        ThemeService.OnChange -= StateHasChanged;
        SidebarService.OnChange -= StateHasChanged;
    }
}