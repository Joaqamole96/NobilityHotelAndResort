using System;

public class Reservation
{
    public int ReservationId { get; set; }
    public int UserId { get; set; }
        public string UserName { get; set; }
    public DateTime CheckInDateTime { get; set; } // Booking.cs | InsertAvailableRoom()
    public DateTime CheckOutDateTime { get; set; } // Booking.cs | InsertAvailableRoom()
    public decimal ReservationPrice { get; set; }
    public string ReservationStatus { get; set; } // Booking.cs | InsertAvailableRoom()

    public void AddRoomPrice(decimal RoomPrice)
    {
        ReservationPrice += RoomPrice;
    }

    public void RemoveRoomPrice(decimal RoomPrice)
    {
        ReservationPrice -= RoomPrice;
    }

    public void AddAmenityPrice(decimal AmenityPrice)
    {
        ReservationPrice += AmenityPrice;
    }

    public void RemoveAmenityPrice(decimal AmenityPrice)
    {
        ReservationPrice -= AmenityPrice;
    }

    public Reservation(DateTime CheckInDateTime, DateTime CheckOutDateTime)
    {
        this.CheckInDateTime = CheckInDateTime;
        this.CheckOutDateTime = CheckOutDateTime;
        ReservationStatus = "draft";
    }
}