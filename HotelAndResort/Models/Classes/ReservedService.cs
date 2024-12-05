using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReservedService
{
    public int ReservedServiceId { get; set; }
    public int ServiceId { get; set; } // Booking.cs | SetReservedServiceAttributes()
        public string ServiceName { get; set; } // Booking.cs | SetReservedServiceAttributes()
        public string ServiceDescription { get; set; } // Booking.cs | SetReservedServiceAttributes()
        public decimal ServicePrice { get; set; } // Booking.cs | SetReservedServiceAttributes()
        public int ServiceCapacity { get; set; } // Booking.cs | SetReservedServiceAttributes()
        public string ServiceStatus { get; set; } // Booking.cs | SetReservedServiceAttributes()
    public int ReservationId { get; set; }
}