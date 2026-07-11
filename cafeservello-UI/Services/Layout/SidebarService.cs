namespace cafeservello_UI.Services.Layout
{
    public sealed class SidebarService
    {
        public bool IsOpen { get; private set; } = true;

        public string CssClass => IsOpen ? "sidebar-open" : "sidebar-close";

        public event Action? OnChange;

        public void ToggleOpen()
        {
            IsOpen = !IsOpen;
            OnChange?.Invoke();
        }
    }
}