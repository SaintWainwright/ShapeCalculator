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

namespace ShapeCalculator.ViewModels
{
    public partial class TriangleViewModel : INotifyPropertyChanged
    {
        //Area
        private double _AreaTriangle = 0;
        public double AreaTriangle
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
        private void CalculateAreaTriangle()
        {
            AreaTriangle = Math.Round(((0.5 * AreaTriangleBase * AreaTriangleHeight)),2);
        }
        public ICommand CalculateAreaTriangleCommand => new Command(CalculateAreaTriangle);

        private void ClearTriangleArea()
        {
            AreaTriangleBase = 0;
            AreaTriangleHeight = 0;
            CalculateAreaTriangle();
        }
        public ICommand ClearTriangleAreaCommand => new Command(ClearTriangleArea);

        //Perimeter of the Triangle
        private double _PerimeterTriangle = 0;
        public double PerimeterTriangle
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

        private void CalculatePerimeterTriangle() 
        {
            PerimeterTriangle = PerimeterTriangleSide1 + PerimeterTriangleBase + PerimeterTriangleSide2;
        }
        public ICommand CalculatePerimeterTriangleCommand => new Command(CalculatePerimeterTriangle);

        private void ClearPerimeterTriangle()
        {
            PerimeterTriangleSide1 = 0;
            PerimeterTriangleBase = 0;
            PerimeterTriangleSide2 = 0;
            CalculatePerimeterTriangle();
        }
        public ICommand ClearPerimeterTriangleCommand => new Command(ClearPerimeterTriangle);

        //Volume of the Triangle
        private double _VolumeTriangle = 0;
        public double VolumeTriangle
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

        private void CalculateVolumeTriangle()
        {
            VolumeTriangle = Math.Round((((1.0 / 3) * Math.PI * Math.Pow(VolumeTriangleRadius, 2) * VolumeTriangleHeight)),2);
        }
        public ICommand CalculateVolumeTriangleCommand => new Command(CalculateVolumeTriangle);
        private void ClearVolumeTriangle()
        {
            VolumeTriangleRadius = 0;
            VolumeTriangleHeight = 0;
            CalculateVolumeTriangle();
        }
        public ICommand ClearVolumeTriangleCommand => new Command(ClearVolumeTriangle);

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
