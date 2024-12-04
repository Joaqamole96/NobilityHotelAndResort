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

    public Reservation(
        int reservedRoomId,
        int roomId,
        string roomNumber,
        string roomType,
        string roomDescription,
        decimal roomPrice,
        int roomCapacity,
        string roomStatus,
        int userId,
        string userName,
        DateTime checkInDateTime,
        DateTime checkOutDateTime,
        int guestCount,
        decimal reservationPrice,
        string reservationStatus)
    {
        ReservedRoomId = reservedRoomId;
        RoomId = roomId;
        RoomNumber = roomNumber;
        RoomType = roomType;
        RoomDescription = roomDescription;
        RoomPrice = roomPrice;
        RoomCapacity = roomCapacity;
        RoomStatus = roomStatus;
        UserId = userId;
        UserName = userName;
        CheckInDateTime = checkInDateTime;
        CheckOutDateTime = checkOutDateTime;
        GuestCount = guestCount;
        ReservationPrice = reservationPrice;
        ReservationStatus = reservationStatus;
    }

    public Reservation()
    {

    }

    public void setRoom()
    {

    }

    public void setUser()
    {

    }
}