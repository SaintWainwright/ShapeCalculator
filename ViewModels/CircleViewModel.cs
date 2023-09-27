using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

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
                OnPropertyChanged();
                OnPropertyChanged(nameof(_RadiusCircle));
            }
        }

        private string _AreaCircle = string.Empty;
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

        private void CalculateAreaCircle()
        {
            AreaCircle = ((2 * Math.PI * RadiusCircle) / 2).ToString();
        }

        public ICommand CalculateAreaCircleCommand => new Command(CalculateAreaCircle);

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
