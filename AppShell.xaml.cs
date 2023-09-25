using CommunityToolkit.Mvvm.Input;
using ShapeCalculator.ViewModels;

namespace ShapeCalculator
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Square), typeof(Square));
        }
    }
}