using ShapeCalculator.ViewModels;
namespace ShapeCalculator;

public partial class Square : ContentPage
{
	public Square()
	{
		InitializeComponent();
		BindingContext = new SquareViewModel(); ;
	}
}