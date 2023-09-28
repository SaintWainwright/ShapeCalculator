
namespace ShapeCalculator
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute(nameof(Triangle), typeof(Triangle));
            Routing.RegisterRoute(nameof(Square), typeof(Square));
            Routing.RegisterRoute(nameof(Rectangle), typeof(Rectangle));
            Routing.RegisterRoute(nameof(Circle), typeof(Circle));
        }
    }
}