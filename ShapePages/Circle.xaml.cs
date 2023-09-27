using ShapeCalculator.ViewModels;

namespace ShapeCalculator;

public partial class Circle : ContentPage
{
	public Circle()
	{
		InitializeComponent();
		BindingContext = new CircleViewModel();
	}
}