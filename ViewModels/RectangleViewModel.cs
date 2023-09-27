using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.ViewModels
{
    public partial class RectangleViewModel : ObservableObject
    {
        [ObservableProperty]
        double _LengthRectangle;

        [ObservableProperty]
        double _WidthRectangle;

        [ObservableProperty]
        double _AreaRectangle;
        [ObservableProperty]
        double _PerimeterRectangle;

        [RelayCommand]
        void CalculateRectangle()
        {
            AreaRectangle = Math.Round((WidthRectangle * LengthRectangle), 2);
            PerimeterRectangle = Math.Round((2 * (WidthRectangle + LengthRectangle)), 2);
        }
        [RelayCommand]
        void ClearRectangle()
        {
            LengthRectangle = 0;
            WidthRectangle = 0;
            CalculateRectangle();
        }

        [ObservableProperty]
        double _LengthRectangleTank;

        [ObservableProperty]
        double _WidthRectangleTank;

        [ObservableProperty]
        double _HeightRectangleTank;

        [ObservableProperty]
        double _VolumeRectangleTank;

        [RelayCommand]
        void CalculateRectangleTank()
        {
            VolumeRectangleTank = Math.Round((LengthRectangleTank * WidthRectangleTank * HeightRectangleTank), 2);
        }

        [RelayCommand]
        void ClearRectangleTank()
        {
            LengthRectangleTank = 0;
            WidthRectangleTank = 0;
            HeightRectangleTank = 0;
            CalculateRectangleTank();
        }
    }
}