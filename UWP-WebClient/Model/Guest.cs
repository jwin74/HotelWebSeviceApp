using System.Collections.Generic;

namespace UWP_WebClient.Model
{
    public class Guest
    {
        public Guest()
        {
            Bookings = new HashSet<Booking>();
        }

        public Guest(int guestNo, string name, string address, ICollection<Booking> bookings)
        {
            Guest_No = guestNo;
            Name = name;
            Address = address;
            Bookings = bookings;
        }

        public int Guest_No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}