using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReservedRoom
{
    public int ReservedRoomId { get; set; }
        public int RoomId { get; set; } // Booking.cs | SetReservedRoomAttributes()
            public string RoomNumber { get; set; } // Booking.cs | SetReservedRoomAttributes()
            public string RoomType { get; set; } // Booking.cs | SetReservedRoomAttributes()
            public string RoomDescription { get; set; } // Booking.cs | SetReservedRoomAttributes()
            public decimal RoomPrice { get; set; } // Booking.cs | SetReservedRoomAttributes()
            public int RoomCapacity { get; set; } // Booking.cs | SetReservedRoomAttributes()
            public string RoomStatus { get; set; } // Booking.cs | SetReservedRoomAttributes()
        public int UserId { get; set; }
            public string UserName { get; set; }
}
