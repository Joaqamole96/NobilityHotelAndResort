using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReservedAmenity
{
    public int ReservedAmenityId { get; set; }
    public int AmenityId { get; set; } // Booking.cs | SetReservedAmenityAttributes()
        public string AmenityName { get; set; } // Booking.cs | SetReservedAmenityAttributes()
        public string AmenityDescription { get; set; } // Booking.cs | SetReservedAmenityAttributes()
        public decimal AmenityPrice { get; set; } // Booking.cs | SetReservedAmenityAttributes()
        public int AmenityCapacity { get; set; } // Booking.cs | SetReservedAmenityAttributes()
        public string AmenityStatus { get; set; } // Booking.cs | SetReservedAmenityAttributes()
    public int ReservationId { get; set; }
}