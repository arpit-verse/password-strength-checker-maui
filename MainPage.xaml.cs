using System.Linq;
namespace MauiApp1;

public partial class MainPage : ContentPage
{
    
    private void OnTogglePassword(object sender, EventArgs e)
{
    PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
    ToggleButton.Text = PasswordEntry.IsPassword ? "Show" : "Hide";
}

    public MainPage()
    {
        InitializeComponent();
    }
    

private void OnPasswordChanged(object sender, TextChangedEventArgs e)
{
    string password = e.NewTextValue ?? "";

    // 👉 Handle empty password first
    if (string.IsNullOrWhiteSpace(password))
    {
        StrengthBar.Progress = 0;
        StrengthLabel.Text = "Enter a password";
        StrengthLabel.TextColor = Colors.Gray;
        StrengthBar.ProgressColor = Colors.Gray;
        return;
    }

    int score = 0;

    if (password.Length >= 8) score++;
    if (password.Any(char.IsUpper)) score++;
    if (password.Any(char.IsLower)) score++;
    if (password.Any(char.IsDigit)) score++;
    if (password.Any(ch => !char.IsLetterOrDigit(ch))) score++;

    StrengthBar.Progress = score / 5.0;

    if (score <= 2)
    {
        StrengthLabel.Text = "Weak Password";
        StrengthLabel.TextColor = Colors.Red;
        StrengthBar.ProgressColor = Colors.Red;
    }
    else if (score <= 4)
    {
        StrengthLabel.Text = "Medium Password";
        StrengthLabel.TextColor = Colors.Orange;
        StrengthBar.ProgressColor = Colors.Orange;
    }
    else
    {
        StrengthLabel.Text = "Strong Password";
        StrengthLabel.TextColor = Colors.Green;
        StrengthBar.ProgressColor = Colors.Green;
    }
}



}
