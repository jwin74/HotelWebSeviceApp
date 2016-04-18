using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UWP_WebClient.Annotations;
using UWP_WebClient.Model;

namespace UWP_WebClient.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        public GuestCatalogSingleton GuestCatalogSingleton { get; set; }

        public ViewModel()
        {
            GuestCatalogSingleton = GuestCatalogSingleton.Instance;
        }

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