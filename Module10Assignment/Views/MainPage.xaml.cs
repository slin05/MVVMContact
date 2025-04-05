using Module10Assignment.ViewModels;

namespace Module10Assignment.Views;

public partial class MainPage : ContentPage
{
    public MainPage(AddContactViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}