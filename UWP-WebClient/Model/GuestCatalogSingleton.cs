using System.Collections.ObjectModel;

namespace AdvWebApi_UWP_App.model
{
    public class GuestCatalogSingleton
    {
        private static GuestCatalogSingleton _instance;

        private GuestCatalogSingleton()
        {
            Guests=new ObservableCollection<Guest>();
        }

        public ObservableCollection<Guest> Guests { get; set; }

        public static GuestCatalogSingleton Instance
        {
            // ReSharper disable once ConvertPropertyToExpressionBody
            get { return _instance ?? (_instance = new GuestCatalogSingleton()); }
        }

        public void Add(Guest newGuest)
        {
            Guests.Add(newGuest);
        }

        public void Remove(Guest guestToBeRemoved)
        {
            Guests.Remove(guestToBeRemoved);
        }
    }
}