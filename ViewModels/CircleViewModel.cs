using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ShapeCalculator.ViewModels
{
    public partial class CircleViewModel : INotifyPropertyChanged
    {
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
        private double _AreaCircle = 0;
        public double AreaCircle
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
        private double _PerimeterCircle = 0;
        public double PerimeterCircle
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
        private double _VolumeCircle = 0;
        public double VolumeCircle
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
            AreaCircle = Math.Round((Math.PI * Math.Pow(RadiusCircle, 2)), 2);
            PerimeterCircle = Math.Round((2 * Math.PI * RadiusCircle), 2);
            VolumeCircle = Math.Round(((4.0/3) * (Math.PI * Math.Pow(RadiusCircle, 3))), 2);
        }

        public ICommand CalculateCircleCommand => new Command(CalculateCircle);
        private void ClearCircle()
        {
            RadiusCircle = 0;
        }
        public ICommand ClearCircleCommand => new Command(ClearCircle);

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
