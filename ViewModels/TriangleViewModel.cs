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
    public partial class TriangleViewModel : MainViewModel
    {

        //Area of the Triangle
        private string _AreaTriangle = "0";
        public string AreaTriangle
        {
            get { return _AreaTriangle; }
            set
            {
                _AreaTriangle = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_AreaTriangle));
            }
        }

        private double _AreaTriangleBase = 0;
        public double AreaTriangleBase
        {
            get { return _AreaTriangleBase; }
            set
            {
                _AreaTriangleBase = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_AreaTriangleBase));
            }
        }

        private double _AreaTriangleHeight = 0;
        public double AreaTriangleHeight
        {
            get { return _AreaTriangleHeight; }
            set
            {
                _AreaTriangleHeight = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_AreaTriangleHeight));
            }
        }

        private string _UnitMeasurementArea = String.Empty;
        public string UnitMeasurementArea
        {
            get { return _UnitMeasurementArea; }
            set
            {
                _UnitMeasurementArea = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_UnitMeasurementArea));
            }
        }
        private void CalculateAreaTriangle()
        {
            AreaTriangle = Math.Round(((0.5 * AreaTriangleBase * AreaTriangleHeight)),2).ToString() + " " + UnitMeasurementArea;
        }
        public ICommand CalculateAreaTriangleCommand => new Command(CalculateAreaTriangle);

        private void ClearTriangleArea()
        {
            AreaTriangleBase = 0;
            AreaTriangleHeight = 0;
            UnitMeasurementArea = string.Empty;
            CalculateAreaTriangle();
        }
        public ICommand ClearTriangleAreaCommand => new Command(ClearTriangleArea);

        //Perimeter of the Triangle
        private string _PerimeterTriangle = "0";
        public string PerimeterTriangle
        {
            get { return _PerimeterTriangle; }
            set
            {
                _PerimeterTriangle = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_PerimeterTriangle));
            }
        }

        private double _PerimeterTriangleSide1 = 0;
        public double PerimeterTriangleSide1
        {
            get { return _PerimeterTriangleSide1; }
            set
            {
                _PerimeterTriangleSide1 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_PerimeterTriangleSide1));
            }
        }

        private double _PerimeterTriangleBase = 0;
        public double PerimeterTriangleBase
        {
            get { return _PerimeterTriangleBase; }
            set
            {
                _PerimeterTriangleBase = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_PerimeterTriangleBase));
            }
        }

        private double _PerimeterTriangleSide2 = 0;
        public double PerimeterTriangleSide2
        {
            get { return _PerimeterTriangleSide2; }
            set
            {
                _PerimeterTriangleSide2 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_PerimeterTriangleSide2));
            }
        }

        private string _UnitMeasurementPerimeter = String.Empty;
        public string UnitMeasurementPerimeter
        {
            get { return _UnitMeasurementPerimeter; }
            set
            {
                _UnitMeasurementPerimeter = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_UnitMeasurementPerimeter));
            }
        }

        private void CalculatePerimeterTriangle() 
        {
            PerimeterTriangle = (PerimeterTriangleSide1 + PerimeterTriangleBase + PerimeterTriangleSide2).ToString() + " " + UnitMeasurementPerimeter;
        }
        public ICommand CalculatePerimeterTriangleCommand => new Command(CalculatePerimeterTriangle);

        private void ClearPerimeterTriangle()
        {
            PerimeterTriangleSide1 = 0;
            PerimeterTriangleBase = 0;
            PerimeterTriangleSide2 = 0;
            UnitMeasurementPerimeter = String.Empty;
            CalculatePerimeterTriangle();
        }
        public ICommand ClearPerimeterTriangleCommand => new Command(ClearPerimeterTriangle);

        //Volume of the Triangle
        private string _VolumeTriangle = "0";
        public string VolumeTriangle
        {
            get { return _VolumeTriangle; }
            set
            {
                _VolumeTriangle = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_VolumeTriangle));
            }
        }

        private double _VolumeTriangleRadius = 0;
        public double VolumeTriangleRadius
        {
            get { return _VolumeTriangleRadius; }
            set
            {
                _VolumeTriangleRadius = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_VolumeTriangleRadius));
            }
        }

        private double _VolumeTriangleHeight = 0;
        public double VolumeTriangleHeight
        {
            get { return _VolumeTriangleHeight; }
            set
            {
                _VolumeTriangleHeight = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_VolumeTriangleHeight));
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

        private void CalculateVolumeTriangle()
        {
            VolumeTriangle = Math.Round((((1.0 / 3) * Math.PI * Math.Pow(VolumeTriangleRadius, 2) * VolumeTriangleHeight)),2).ToString() + " " + UnitMeasurementVolume;
        }
        public ICommand CalculateVolumeTriangleCommand => new Command(CalculateVolumeTriangle);
        private void ClearVolumeTriangle()
        {
            VolumeTriangleRadius = 0;
            VolumeTriangleHeight = 0;
            UnitMeasurementVolume = string.Empty;
            CalculateVolumeTriangle();
        }
        public ICommand ClearVolumeTriangleCommand => new Command(ClearVolumeTriangle);
    }
}
