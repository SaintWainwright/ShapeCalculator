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
        [ObservableProperty]
        private decimal _AreaTriangle;

        [ObservableProperty]
        private decimal _AreaTriangleBase = 0;

        [ObservableProperty]
        private decimal _AreaTriangleHeight = 0;

        [RelayCommand]
        private void CalculateArea()
        {
            AreaTriangle = ((decimal)0.5 * AreaTriangleBase * AreaTriangleHeight);
        }
    }
}
