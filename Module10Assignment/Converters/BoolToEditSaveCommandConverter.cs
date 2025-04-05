using Module10Assignment.ViewModels;
using System.Globalization;

namespace Module10Assignment.Converters;

public class BoolToEditSaveCommandConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (parameter == null)
            return null;

        var vm = parameter as ContactDetailsViewModel;
        if (vm == null)
            return null;

        return (bool)value ? vm.SaveChangesCommand : vm.ToggleEditCommand;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}