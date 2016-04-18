using System.Collections.Generic;

namespace UWP_WebClient.Model
{
    public class Room
    {
        public Room()
        {
            Bookings = new HashSet<Booking>();
        }

        public Room(int roomNo, int hotelNo, string types, double? price, ICollection<Booking> bookings, Hotel hotel)
        {
            Room_No = roomNo;
            Hotel_No = hotelNo;
            Types = types;
            Price = price;
            Bookings = bookings;
            Hotel = hotel;
        }

        public int Room_No { get; set; }
        public int Hotel_No { get; set; }
        public string Types { get; set; }
        public double? Price { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}