using System.ComponentModel;

namespace ShapeCalculator.ViewModels
{
    public partial class CircleViewModel : INotifyPropertyChanged
    {
        private double _RadiusCircle = 0;
        public double RadiusCircle
        {
            get { return _RadiusCircle; }
            set
            {
                _RadiusCircle = value;
                OnPropertyChanged(nameof(_RadiusCircle));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) =>  
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
