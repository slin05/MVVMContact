using Module10Assignment.Views;

namespace Module10Assignment;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Register routes
        Routing.RegisterRoute("ContactDetailsPage", typeof(ContactDetailsPage));
    }
}