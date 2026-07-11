namespace cafeservello_UI.Services.Common.Theme
{
    public sealed class ThemeService
    {
        public string ThemeColor { get; private set; } = "";

        public event Action? OnChange;

        public void ToggleTheme()
        {
            ThemeColor = ThemeColor == "light" ? "" : "light";

            OnChange?.Invoke();
        }
    }
}
