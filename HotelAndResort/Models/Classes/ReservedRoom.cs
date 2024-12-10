using HotelAndResort.Models.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public int ReservationId { get; set; }
        public int GuestCount { get; set; }
        public decimal ReservedRoomPrice { get; set; }

    public void InsertToDatabase()
    {
        try
        {
            // Construct the SQL INSERT query
            string query = $@"
            INSERT INTO Reserved_Rooms (room_id, reservation_id, guest_count, reserved_room_price)
            VALUES (
                {RoomId}, 
                {ReservationId}, 
                {GuestCount}, 
                {ReservedRoomPrice.ToString("F2")}
            );";

            // Execute the query
            DatabaseHelper.Execute(query);
        }
        catch (Exception ex)
        {
            throw new Exception($"Error inserting reserved room into the database: {ex.Message}");
        }
    }

}
