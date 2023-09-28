using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ShapeCalculator.ViewModels;

namespace ShapeCalculator.ViewModels
{
    public partial class RectangleViewModel : MainViewModel
    {
        private double _LengthRectangle = 0;
        public double LengthRectangle
        {
            get { return _LengthRectangle; }
            set
            {
                _LengthRectangle = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_LengthRectangle));
            }
        }
        private double _WidthRectangle = 0;
        public double WidthRectangle
        {
            get { return _WidthRectangle; }
            set
            {
                _WidthRectangle = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_WidthRectangle));
            }
        }
        private string _AreaRectangle = "0";
        public string AreaRectangle
        {
            get { return _AreaRectangle; }
            set
            {
                _AreaRectangle = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_AreaRectangle));
            }
        }
        private string _PerimeterRectangle = "0";
        public string PerimeterRectangle
        {
            get { return _PerimeterRectangle; }
            set
            {
                _PerimeterRectangle = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_PerimeterRectangle));
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

        private void CalculateRectangle()
        {
            AreaRectangle = Math.Round((WidthRectangle * LengthRectangle), 2).ToString() + " " + UnitMeasurement;
            PerimeterRectangle = ((2 * WidthRectangle) + (2 * LengthRectangle)).ToString() + " " + UnitMeasurement;
        }
        public ICommand CalculateRectangleCommand => new Command(CalculateRectangle);

        //Clear Rectangle
        private void ClearRectangle()
        {
            LengthRectangle = 0;
            WidthRectangle = 0;
            UnitMeasurement = string.Empty;
            CalculateRectangle();
        }
        public ICommand ClearRectangleCommand => new Command(ClearRectangle);

        //Rectangle Tank
        private double _LengthRectangleTank = 0;
        public double LengthRectangleTank
        {
            get { return _LengthRectangleTank; }
            set
            {
                _LengthRectangleTank = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_LengthRectangleTank));
            }
        }

        private double _WidthRectangleTank = 0;
        public double WidthRectangleTank
        {
            get { return _WidthRectangleTank; }
            set
            {
                _WidthRectangleTank = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_WidthRectangleTank));
            }
        }

        private double _HeightRectangleTank = 0;
        public double HeightRectangleTank
        {
            get { return _HeightRectangleTank; }
            set
            {
                _HeightRectangleTank = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_HeightRectangleTank));
            }
        }

        private string _VolumeRectangleTank = "0";
        public string VolumeRectangleTank
        {
            get { return _VolumeRectangleTank; }
            set
            {
                _VolumeRectangleTank = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_VolumeRectangleTank));
            }
        }

        private string _UnitMeasurementVolume = String.Empty;
        public string UnitMeasurementVolume
        {
            get { return _UnitMeasurementVolume; }
            set
            {
                _UnitMeasurementVolume = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_UnitMeasurementVolume));
            }
        }

        private void CalculateRectangleTank()
        {
            VolumeRectangleTank = Math.Round((LengthRectangleTank * WidthRectangleTank * HeightRectangleTank), 2).ToString() + " " + UnitMeasurementVolume;
        }

        public ICommand CalculateRectangleTankCommand => new Command(CalculateRectangleTank);
        private void ClearRectangleTank()
        {
            LengthRectangleTank = 0;
            WidthRectangleTank = 0;
            HeightRectangleTank = 0;
            UnitMeasurementVolume = string.Empty;
            CalculateRectangleTank();
        }
        public ICommand ClearRectangleTankCommand => new Command(ClearRectangleTank);
    }
}