using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class Registerpage : ContentPage
{
    public Registerpage()
    {
        InitializeComponent();
        BindingContext = new RegisterViewModel();
    }
}