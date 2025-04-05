using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Module10Assignment.Models;
using System.Collections.ObjectModel;

namespace Module10Assignment.ViewModels;

public partial class ContactsViewModel : BaseViewModel
{
    public ObservableCollection<ContactModel> Contacts { get; } = new();

    [ObservableProperty]
    private ContactModel _selectedContact;

    public ContactsViewModel()
    {
        Title = "Contacts";
    }

    [RelayCommand]
    async Task GoToAddContact()
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

    [RelayCommand]
    async Task ContactSelected(ContactModel contact = null)
    {
        var selectedContact = contact ?? SelectedContact;

        if (selectedContact == null)
            return;

        var parameters = new Dictionary<string, object>
        {
            { "Contact", selectedContact }
        };

        await Shell.Current.GoToAsync("ContactDetailsPage", parameters);

        SelectedContact = null;
    }
}