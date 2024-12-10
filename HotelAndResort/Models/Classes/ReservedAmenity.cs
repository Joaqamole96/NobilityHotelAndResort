using HotelAndResort.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    public void InsertToDatabase()
    {
        try
        {
            // Construct the SQL INSERT query
            string query = $@"
            INSERT INTO Reserved_Amenities (amenity_id, reservation_id)
            VALUES (
                {AmenityId}, 
                {ReservationId}
            );";

            // Execute the query
            DatabaseHelper.Execute(query);
            MessageBox.Show("Inserted reserved amenity");
        }
        catch (Exception ex)
        {
            throw new Exception($"Error inserting reserved amenity into the database: {ex.Message}");
        }
    }

}