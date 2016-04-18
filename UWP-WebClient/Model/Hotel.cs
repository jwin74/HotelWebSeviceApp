using System.Collections.Generic;

namespace UWP_WebClient.Model
{
    public class Hotel
    {
        public Hotel()
        {
            Rooms = new HashSet<Room>();
        }

        public Hotel(int hotelNo, string name, string address, ICollection<Room> rooms)
        {
            Hotel_No = hotelNo;
            Name = name;
            Address = address;
            Rooms = rooms;
        }

        public int Hotel_No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}