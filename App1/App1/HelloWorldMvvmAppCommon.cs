using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelloWorldMvvmApp.Commons
{
    public class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual bool SetProperty <T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if(Equals(field, value)) { return false; }
            field = value;
            this.OnPropertyChanged(PropertyChanged);
            return true;
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}