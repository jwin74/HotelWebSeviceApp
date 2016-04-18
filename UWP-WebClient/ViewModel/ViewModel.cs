using System.ComponentModel;
using System.Runtime.CompilerServices;
using UWP_WebClient.Annotations;
using UWP_WebClient.Model;

namespace UWP_WebClient.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            GuestCatalogSingleton = GuestCatalogSingleton.Instance;
        }

        public GuestCatalogSingleton GuestCatalogSingleton { get; set; }
        public static Guest SelectedGuest { get; set; }

        #region PropertyChangedSupport

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}