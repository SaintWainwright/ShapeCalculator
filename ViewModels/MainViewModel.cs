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
    }
}
