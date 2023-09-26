using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ShapeCalculator;

public partial class Triangle : ContentPage
{
	public Triangle()
	{
		InitializeComponent();
	}

	decimal areaTriangleBase = 0;
	decimal areaTriangleHeight = 0;
	decimal areaTriangle;

	public decimal AreaTriangle
	{
		get { return areaTriangleBase; }
		set
		{
			areaTriangle = value;
			OnPropertyChanged();
		}
	}
	public void InitializeAreaTriangle()
	{
		areaTriangleBase = Int32.Parse(txtEntryEdge1.Text);
		areaTriangleHeight = Int32.Parse(txtEntryEdge2.Text);
	}

	public void CalculateArea()
	{
        InitializeAreaTriangle();
		AreaTriangle = ((decimal) 0.5 * areaTriangleBase * areaTriangleHeight);
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		CalculateArea();
    }
}