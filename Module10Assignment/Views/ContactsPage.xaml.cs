using Module10Assignment.Models;
using Module10Assignment.ViewModels;

namespace Module10Assignment.Views;

public partial class ContactsPage : ContentPage
{
    private ContactsViewModel _viewModel;

    public ContactsPage(ContactsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        _viewModel = viewModel;
    }

    private void OnContactSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is ContactModel selectedContact)
        {
            _viewModel.SelectedContact = selectedContact;

            if (_viewModel.ContactSelectedCommand.CanExecute(null))
                _viewModel.ContactSelectedCommand.Execute(null);
        }
    }
}