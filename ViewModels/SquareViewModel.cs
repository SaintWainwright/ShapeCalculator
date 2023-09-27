using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShapeCalculator.ViewModels
{
    public partial class SquareViewModel : INotifyPropertyChanged
    {
        //Set up for binding of Side of Square
        private double _SideSquare = 0;
        public double SideSquare
        {
            get { return _SideSquare; }
            set
            {
                _SideSquare = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_SideSquare));
            }
        }

        //Binding of Area of Square
        private double _AreaSquare = 0;
        public double AreaSquare
        {
            get { return _AreaSquare; }
            set
            {
                _AreaSquare = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_AreaSquare));
            }
        }

        //Binding the Perimeter of the Square
        private double _PerimeterSquare = 0;
        public double PerimeterSquare
        {
            get { return _PerimeterSquare; }
            set
            {
                _PerimeterSquare = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_PerimeterSquare));
            }
        }

        //Binding Volume of the Square(Cube)
        private double _VolumeSquare = 0;
        public double VolumeSquare
        {
            get { return _VolumeSquare; }
            set
            {
                _VolumeSquare = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_VolumeSquare));
            }
        }

        private void CalculateSquare()
        {
            AreaSquare = Math.Round(Math.Pow(SideSquare, 2), 2);
            PerimeterSquare = Math.Round((4 * SideSquare), 2);
            VolumeSquare = Math.Round(Math.Pow(SideSquare, 3), 2);
        }

        public ICommand CalculateSquareCommand => new Command(CalculateSquare);
        private void ClearSquare()
        {
            SideSquare = 0;
        }
        public ICommand ClearCircleCommand => new Command(ClearSquare);

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
