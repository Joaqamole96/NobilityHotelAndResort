using HotelAndResort;
using HotelAndResort.Models.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

public class Reservation
{
    public int ReservationId { get; set; }
    public int UserId { get; set; }
        public string UserName { get; set; }
    public DateTime CheckInDateTime { get; set; } // Booking.cs | InsertAvailableRoom()
    public DateTime CheckOutDateTime { get; set; } // Booking.cs | InsertAvailableRoom()
    public int NightCount { get; set; }
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

    public Reservation()
    {
        ReservationStatus = "draft";
    }

    public int InsertToDatabase()
    {
        try
        {
            // Construct the SQL INSERT query
            string query = $@"
                INSERT INTO Reservation (user_id, check_in_datetime, check_out_datetime, night_count, reservation_price, reservation_status) 
                VALUES (
                    {Global.UserId}, 
                    '{CheckInDateTime}', 
                    '{CheckOutDateTime}', 
                    {NightCount}, 
                    {ReservationPrice}, 
                    '{ReservationStatus}'
                );";

            // Execute the insert query using DatabaseHelper.Execute
            DatabaseHelper.Execute(query);
            MessageBox.Show("Inserted reservation");

            // After inserting, get the last inserted ID
            string lastInsertIdQuery = "SELECT LAST_INSERT_ID();";
            DataTable resultTable = DatabaseHelper.Select(lastInsertIdQuery);

            if (resultTable.Rows.Count > 0)
            {
                return Convert.ToInt32(resultTable.Rows[0][0]);
            }
            else
            {
                throw new Exception("Failed to retrieve the last inserted ID.");
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error inserting reservation into the database: {ex.Message}");
        }
    }

}