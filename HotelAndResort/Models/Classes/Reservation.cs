using System;

public class Reservation
{
    public int ReservationId { get; set; }
    public int ReservedRoomId { get; set; }
        public int RoomId { get; set; }
            public string RoomNumber { get; set; } // Booking.cs | SetReservationAttributes()
            public string RoomType { get; set; } // Booking.cs | SetReservationAttributes()
            public string RoomDescription { get; set; } // Booking.cs | SetReservationAttributes()
            public decimal RoomPrice { get; set; } // Booking.cs | SetReservationAttributes()
            public int RoomCapacity { get; set; } // Booking.cs | SetReservationAttributes()
            public string RoomStatus { get; set; } // Booking.cs | SetReservationAttributes()
        public int UserId { get; set; }
            public string UserName { get; set; }
    public DateTime CheckInDateTime { get; set; } // Booking.cs | InsertAvailableRoom()
    public DateTime CheckOutDateTime { get; set; } // Booking.cs | InsertAvailableRoom()
    public int GuestCount { get; set; } // Booking.cs | InsertAvailableRoom()
    public decimal ReservationPrice { get; set; }
    public string ReservationStatus { get; set; } // Booking.cs | InsertAvailableRoom()

    public void AddServicePrice(decimal ServicePrice)
    {
        ReservationPrice += ServicePrice;
    }

    public void RemoveServicePrice(decimal ServicePrice)
    {
        ReservationPrice -= ServicePrice;
    }

    public Reservation(){}
}