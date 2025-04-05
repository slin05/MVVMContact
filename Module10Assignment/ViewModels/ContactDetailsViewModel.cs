using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Module10Assignment.Models;

namespace Module10Assignment.ViewModels;

[QueryProperty(nameof(Contact), "Contact")]
public partial class ContactDetailsViewModel : BaseViewModel
{
    [ObservableProperty]
    private ContactModel _contact; 

    [ObservableProperty]
    private bool _isEditing;

    public ContactDetailsViewModel()
    {
        Title = "Contact Details";
    }

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    void ToggleEdit()
    {
        IsEditing = !IsEditing;
    }

    [RelayCommand]
    async Task SaveChanges()
    {
        if (string.IsNullOrWhiteSpace(Contact.Name) || string.IsNullOrWhiteSpace(Contact.Email))
        {
            await Shell.Current.DisplayAlert("Error", "Name and Email are required!", "OK");
            return;
        }

        IsEditing = false;
        await Shell.Current.DisplayAlert("Success", "Contact updated successfully!", "OK");
    }
}