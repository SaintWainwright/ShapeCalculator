using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.ViewModels
{
    public partial class TriangleViewModel : ObservableObject
    {
        //Area
        [ObservableProperty]
        private double _AreaTriangle = 0;
        [ObservableProperty]
        private double _AreaTriangleBase = 0;
        [ObservableProperty]
        private double _AreaTriangleHeight = 0;

        [RelayCommand]
        private void CalculateAreaTriangle()
        {
            AreaTriangle = (0.5 * AreaTriangleBase * AreaTriangleHeight);
        }
        [RelayCommand]
        private void ClearTriangleArea()
        {
            AreaTriangle = 0;
            AreaTriangleBase = 0;
            AreaTriangleHeight = 0;
        }

        //Perimeter of the Triangle
        [ObservableProperty]
        private double _PerimeterTriangle = 0;
        [ObservableProperty]
        private double _PerimeterTriangleSide1 = 0;
        [ObservableProperty]
        private double _PerimeterTriangleBase = 0;
        [ObservableProperty]
        private double _PerimeterTriangleSide2 = 0;

        [RelayCommand]
        private void CalculatePerimeterTriangle() 
        {
            PerimeterTriangle = PerimeterTriangleSide1 + PerimeterTriangleBase + PerimeterTriangleSide2;
        }
        [RelayCommand]
        private void ClearPerimeterTriangle()
        {
            PerimeterTriangle = 0;
            PerimeterTriangleSide1 = 0;
            PerimeterTriangleBase = 0;
            PerimeterTriangleSide2 = 0;
        }

        //Volume of the Triangle
        [ObservableProperty]
        private double _VolumeTriangle = 0;
        [ObservableProperty]
        private double _VolumeTriangleRadius = 0;
        [ObservableProperty]
        private double _VolumeTriangleHeight = 0;

        [RelayCommand]
        private void CalculateVolumeTriangle()
        {
            VolumeTriangle = ((1/3) * Math.PI * Math.Pow(VolumeTriangleRadius, 2) * VolumeTriangleHeight);
        }
        [RelayCommand]
        private void ClearVolumeTriangle()
        {
            VolumeTriangle = 0;
            VolumeTriangleRadius = 0;
            VolumeTriangleHeight = 0;
        }
    }
}
