using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Module10Assignment.Models;
using System.Collections.ObjectModel;

namespace Module10Assignment.ViewModels;

public partial class AddContactViewModel : BaseViewModel
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private string _email;

    [ObservableProperty]
    private string _phoneNumber;

    [ObservableProperty]
    private string _description;

    private readonly ContactsViewModel _contactsViewModel;

    public AddContactViewModel(ContactsViewModel contactsViewModel)
    {
        Title = "Add Contact";
        _contactsViewModel = contactsViewModel;
    }

    [RelayCommand]
    async Task SaveContact()
    {
        if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Email))
        {
            await Shell.Current.DisplayAlert("Error", "Name and Email are required!", "OK");
            return;
        }

        var newContact = new ContactModel 
        {
            Name = Name,
            Email = Email,
            PhoneNumber = PhoneNumber,
            Description = Description
        };

        _contactsViewModel.Contacts.Add(newContact);

        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
        Description = string.Empty;

        await Shell.Current.GoToAsync("//ContactsPage");
    }
}