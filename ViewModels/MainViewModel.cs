using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [RelayCommand]
        void OnSquare()
        {
            Shell.Current.GoToAsync(nameof(Square));
        }

        [RelayCommand]
        void OnTriangle()
        {
            Shell.Current.GoToAsync(nameof(Triangle));
        }

        [RelayCommand]
        void OnRectangle()
        {
            Shell.Current.GoToAsync(nameof(Rectangle));
        }

        [RelayCommand]
        void OnCircle()
        {
            Shell.Current.GoToAsync(nameof(Circle));
        }
    }
}
