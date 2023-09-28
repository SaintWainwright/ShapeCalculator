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
    public partial class SquareViewModel : MainViewModel
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
        private string _AreaSquare = "0";
        public string AreaSquare
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
        private string _PerimeterSquare = "0";
        public string PerimeterSquare
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
        private string _VolumeSquare = "0";
        public string VolumeSquare
        {
            get { return _VolumeSquare; }
            set
            {
                _VolumeSquare = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_VolumeSquare));
            }
        }

        private string _UnitMeasurement = String.Empty;
        public string UnitMeasurement
        {
            get { return _UnitMeasurement; }
            set
            {
                _UnitMeasurement = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_UnitMeasurement));
            }
        }

        private void CalculateSquare()
        {
            AreaSquare = Math.Round(Math.Pow(SideSquare, 2), 2).ToString() + " " + UnitMeasurement;
            PerimeterSquare = Math.Round((4 * SideSquare), 2).ToString() + " " + UnitMeasurement;
            VolumeSquare = Math.Round(Math.Pow(SideSquare, 3), 2).ToString() + " " + UnitMeasurement;
        }

        public ICommand CalculateSquareCommand => new Command(CalculateSquare);
        private void ClearSquare()
        {
            SideSquare = 0;
            UnitMeasurement = String.Empty;
            CalculateSquare();
        }
        public ICommand ClearSquareCommand => new Command(ClearSquare);
    }
}
