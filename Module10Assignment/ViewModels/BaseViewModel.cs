using CommunityToolkit.Mvvm.ComponentModel;

namespace Module10Assignment.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _isBusy;

    [ObservableProperty]
    private string _title;
}