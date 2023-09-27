using ShapeCalculator.ViewModels;
namespace ShapeCalculator;

public partial class Rectangle : ContentPage
{
	public Rectangle()
	{
		InitializeComponent();
		BindingContext = new RectangleViewModel();
	}
}