using System;

namespace UWP_WebClient.Model
{
    public class Booking
    {
        public Booking(int bookingId, int hotelNo, int guestNo, DateTime dateFrom, DateTime dateTo, int roomNo,
            Room room, Guest guest)
        {
            Booking_id = bookingId;
            Hotel_No = hotelNo;
            Guest_No = guestNo;
            Date_From = dateFrom;
            Date_To = dateTo;
            Room_No = roomNo;
            Room = room;
            Guest = guest;
        }

        public int Booking_id { get; set; }
        public int Hotel_No { get; set; }
        public int Guest_No { get; set; }
        public DateTime Date_From { get; set; }
        public DateTime Date_To { get; set; }
        public int Room_No { get; set; }
        public virtual Room Room { get; set; }
        public virtual Guest Guest { get; set; }
    }
}