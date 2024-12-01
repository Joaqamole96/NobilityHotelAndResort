-- Drop the database if it exists to ensure a fresh setup
DROP DATABASE IF EXISTS nobilityhotelandresort_db;

-- Create the database if it doesn't exist
CREATE DATABASE IF NOT EXISTS nobilityhotelandresort_db;

-- Use the created database
USE nobilityhotelandresort_db;

-- Drop existing tables for a clean slate
DROP TABLE IF EXISTS HomeContent;

DROP TABLE IF EXISTS Reserved_Services;
DROP TABLE IF EXISTS Reserved_Rooms;
DROP TABLE IF EXISTS Available_Rooms;
DROP TABLE IF EXISTS Available_Services;
DROP TABLE IF EXISTS Services;
DROP TABLE IF EXISTS Rooms;
DROP TABLE IF EXISTS Users;






-- Create HomeContent table
CREATE TABLE HomeContent (
    homecontent_id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(50),
    heading VARCHAR(50),
    description VARCHAR(255),
    button_txt VARCHAR(15)
);





INSERT INTO HomeContent (title, heading, description, button_txt)
VALUES
("Services", "Experience the Fun", "Safety and comfort are key factors in leisure stays these days. We assure you of medical-grade stringent sanitation procedures in preparing our rooms for guests so you can stay with us with peace of mind.", "Book Now");

INSERT INTO HomeContent (title, heading, description, button_txt)
VALUES
("Rooms", "Experience the Comfort", "Safety and comfort are key factors in leisure stays these days. We assure you of medical-grade stringent sanitation procedures in preparing our rooms for guests so you can stay with us with peace of mind.", "Book Now");






-- Create Users table
CREATE TABLE Users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    phone_number VARCHAR(15),
    role ENUM('admin', 'guest') DEFAULT 'guest',
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Create Rooms table
CREATE TABLE Rooms (
    room_id INT AUTO_INCREMENT PRIMARY KEY,
    room_number VARCHAR(10) NOT NULL,
    room_type VARCHAR(50) NOT NULL,
    description TEXT,
    price DECIMAL(10, 2) NOT NULL,
    capacity INT NOT NULL,
    status ENUM('available', 'reserved', 'maintenance') DEFAULT 'available'
);

-- Create Available_Rooms table
CREATE TABLE Available_Rooms (
    availableroom_id INT AUTO_INCREMENT PRIMARY KEY,
    room_id INT NOT NULL,
    is_available BOOLEAN DEFAULT TRUE,
    date DATE NOT NULL,

    FOREIGN KEY (room_id) REFERENCES Rooms(room_id)
);

-- Create Reserved_Rooms table
CREATE TABLE Reserved_Rooms (
    reservation_id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT NOT NULL,
    room_id INT NOT NULL,
    check_in_date DATE NOT NULL,
    check_out_date DATE NOT NULL,
    total_price DECIMAL(10, 2) NOT NULL,
    has_services BOOLEAN DEFAULT FALSE,
    status ENUM('reserved', 'canceled', 'checked-in') DEFAULT 'reserved',
    
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (room_id) REFERENCES Rooms(room_id)
);

-- Create Services table
CREATE TABLE Services (
    service_id INT AUTO_INCREMENT PRIMARY KEY,
    service_name VARCHAR(50) NOT NULL,
    description TEXT,
    price DECIMAL(10, 2) NOT NULL,
    quantity INT NOT NULL,
    status ENUM('available', 'reserved', 'maintenance') DEFAULT 'available'
);

-- Create Available_Services table
CREATE TABLE Available_Services (
    availableservice_id INT AUTO_INCREMENT PRIMARY KEY,
    service_id INT NOT NULL,
    is_available BOOLEAN DEFAULT TRUE,
    date DATE NOT NULL,

    FOREIGN KEY (service_id) REFERENCES Services(service_id)
);

-- Create Reserved_Services table
CREATE TABLE Reserved_Services (
    reserved_service_id INT AUTO_INCREMENT PRIMARY KEY,
    reservation_id INT NOT NULL,
    service_id INT NOT NULL,
    total_price DECIMAL(10, 2) NOT NULL,
    
    FOREIGN KEY (reservation_id) REFERENCES Reserved_Rooms(reservation_id),
    FOREIGN KEY (service_id) REFERENCES Services(service_id)
);





-- Insert Standard Rooms
INSERT INTO Rooms (room_number, room_type, description, price, capacity, status)
VALUES 
('101', 'Standard Room', 'A basic room with essential amenities.', 2000.00, 2, 'available'),
('102', 'Standard Room', 'A basic room with essential amenities.', 2000.00, 2, 'available'),
('103', 'Standard Room', 'A basic room with essential amenities.', 2000.00, 2, 'available'),
('104', 'Standard Room', 'A basic room with essential amenities.', 2000.00, 2, 'available'),
('105', 'Standard Room', 'A basic room with essential amenities.', 2000.00, 2, 'available');

-- Insert Premium Rooms
INSERT INTO Rooms (room_number, room_type, description, price, capacity, status)
VALUES 
('201', 'Premium Room', 'A more spacious room with additional features.', 3500.00, 3, 'available'),
('202', 'Premium Room', 'A more spacious room with additional features.', 3500.00, 3, 'available'),
('203', 'Premium Room', 'A more spacious room with additional features.', 3500.00, 3, 'available'),
('204', 'Premium Room', 'A more spacious room with additional features.', 3500.00, 3, 'available'),
('205', 'Premium Room', 'A more spacious room with additional features.', 3500.00, 3, 'available');

-- Insert Deluxe Rooms
INSERT INTO Rooms (room_number, room_type, description, price, capacity, status)
VALUES 
('301', 'Deluxe Room', 'A luxurious room with top-notch facilities.', 5000.00, 4, 'available'),
('302', 'Deluxe Room', 'A luxurious room with top-notch facilities.', 5000.00, 4, 'available'),
('303', 'Deluxe Room', 'A luxurious room with top-notch facilities.', 5000.00, 4, 'available'),
('304', 'Deluxe Room', 'A luxurious room with top-notch facilities.', 5000.00, 4, 'available'),
('305', 'Deluxe Room', 'A luxurious room with top-notch facilities.', 5000.00, 4, 'available');





-- Insert Services
INSERT INTO Services (service_name, description, price, quantity, status)
VALUES
("Public Pool", "A pool accessible by the hotel and resort patrons.", 200,1, "available"),
("Private Pool", "A private pool that can be rented hourly by the hotel and resort patrons.", 300, 1, "available"),
("Party Area", "A venue to hold celebrations and functions.", 3000, 1, "available"),
("Cottage", "A small hut near the resort's pools.", 1500, 4, "available");





INSERT INTO Available_Rooms (room_id, is_available, date)
SELECT room_id, TRUE, CURRENT_TIMESTAMP FROM Rooms;

INSERT INTO Available_Services (service_id, is_available, date)
SELECT service_id, TRUE, CURRENT_TIMESTAMP FROM Services;