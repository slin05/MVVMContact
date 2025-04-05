using Module10Assignment.ViewModels;

namespace Module10Assignment.Views;

public partial class ContactDetailsPage : ContentPage
{
    public ContactDetailsPage(ContactDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}