using ShapeCalculator.ViewModels;

namespace ShapeCalculator;

public partial class Triangle : ContentPage
{
	public Triangle()
	{
		InitializeComponent();
		BindingContext = new TriangleViewModel();
	}
}