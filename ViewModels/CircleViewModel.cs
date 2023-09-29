using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace ShapeCalculator.ViewModels
{
    public partial class CircleViewModel : MainViewModel
    {
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

        //Set up for binding of Radius of Circle
        private double _RadiusCircle = 0;
        public double RadiusCircle
        {
            get { return _RadiusCircle; }
            set
            {
                _RadiusCircle = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_RadiusCircle));
            }
        }

        //Binding of Area of Circle
        private string _AreaCircle = "0";
        public string AreaCircle
        {
            get { return _AreaCircle; }
            set 
            {
                _AreaCircle = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_AreaCircle));
            }
        }

        //Binding the Perimeter of the Circle
        private string _PerimeterCircle = "0";
        public string PerimeterCircle
        {
            get { return _PerimeterCircle; }
            set 
            { 
                _PerimeterCircle = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_PerimeterCircle));
            }
        }

        //Binding Volume of the Circle(Sphere)
        private string _VolumeCircle = "0";
        public string VolumeCircle
        {
            get { return _VolumeCircle; }
            set
            {
                _VolumeCircle = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(_VolumeCircle));
            }
        }

        private void CalculateCircle()
        {
            AreaCircle = Math.Round((Math.PI * Math.Pow(RadiusCircle, 2)), 2).ToString() + " " + UnitMeasurement;
            PerimeterCircle = Math.Round((2 * Math.PI * RadiusCircle), 2).ToString() + " " + UnitMeasurement;
            VolumeCircle = Math.Round(((4.0/3) * (Math.PI * Math.Pow(RadiusCircle, 3))), 2).ToString() + " " + UnitMeasurement;
        }

        public ICommand CalculateCircleCommand => new Command(CalculateCircle);
        private void ClearCircle()
        {
            RadiusCircle = 0;
            UnitMeasurement = string.Empty;
            CalculateCircle();
        }
        public ICommand ClearCircleCommand => new Command(ClearCircle);
    }
}
