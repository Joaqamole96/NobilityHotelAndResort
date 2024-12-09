-- Drop the database if it exists to ensure a fresh setup
DROP DATABASE IF EXISTS nobilityhotelandresort_db;

-- Create the database
CREATE DATABASE IF NOT EXISTS nobilityhotelandresort_db;

-- Use the created database
USE nobilityhotelandresort_db;

-- Drop existing tables for a clean slate
DROP TABLE IF EXISTS HomeContent;
DROP TABLE IF EXISTS Reserved_Services;
DROP TABLE IF EXISTS Reserved_Amenities;
DROP TABLE IF EXISTS Reserved_Rooms;
DROP TABLE IF EXISTS Services;
DROP TABLE IF EXISTS Amenities;
DROP TABLE IF EXISTS Rooms;
DROP TABLE IF EXISTS Users;

-- Create Users tablem
CREATE TABLE Users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    user_name VARCHAR(50) UNIQUE NOT NULL,
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
    room_description TEXT,
    room_price DECIMAL(10, 2) NOT NULL,
    room_capacity INT NOT NULL,
    room_status ENUM('available', 'reserved', 'maintenance') DEFAULT 'available'
);

-- Create Amenities table
CREATE TABLE Amenities (
    amenity_id INT AUTO_INCREMENT PRIMARY KEY,
    amenity_name VARCHAR(50) NOT NULL,
    amenity_description TEXT,
    amenity_price DECIMAL(10, 2) NOT NULL,
    amenity_capacity INT NOT NULL,
    amenity_status ENUM('available', 'reserved', 'maintenance') DEFAULT 'available'
);

-- Create Reservation table
CREATE TABLE Reservation (
    reservation_id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT,
    check_in_datetime DATETIME NOT NULL,
    check_out_datetime DATETIME NOT NULL,
    reservation_price DECIMAL(10, 2) NOT NULL,
    reservation_status ENUM("draft", "booked", "cancelled", "checked_in", "checked_out") NOT NULL DEFAULT "draft",

    FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE ON UPDATE CASCADE
);

-- Create Reserved_Rooms table
CREATE TABLE Reserved_Rooms (
    reserved_room_id INT AUTO_INCREMENT PRIMARY KEY,
    room_id INT,
    reservation_id INT,
    guest_count INT NOT NULL,
    reserved_room_price DECIMAL(10, 2) NOT NULL,

    FOREIGN KEY (room_id) REFERENCES Rooms(room_id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (reservation_id) REFERENCES Reservation(reservation_id) ON DELETE CASCADE ON UPDATE CASCADE
);

-- Create Reserved_Amenities table
CREATE TABLE Reserved_Amenities (
    reserved_amenity_id INT AUTO_INCREMENT PRIMARY KEY,
    amenity_id INT,
    reservation_id INT,

    FOREIGN KEY (amenity_id) REFERENCES Amenities(amenity_id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (reservation_id) REFERENCES Reservation(reservation_id) ON DELETE CASCADE ON UPDATE CASCADE
);

-- Insert Users
INSERT INTO Users (user_name, password, email, role)
VALUES
('admin_user', 'securepassword123', 'admin@example.com', 'admin'),
('guest_user', 'guestpassword123', 'guest@example.com', 'guest');

-- Insert Standard Rooms
INSERT INTO Rooms (room_number, room_type, room_description, room_price, room_capacity, room_status)
VALUES 
('101', 'Standard Room', 'A basic room with essential amenities.', 2000.00, 2, 'available'),
('102', 'Standard Room', 'A basic room with essential amenities.', 2000.00, 2, 'available'),
('103', 'Standard Room', 'A basic room with essential amenities.', 2000.00, 2, 'available'),
('104', 'Standard Room', 'A basic room with essential amenities.', 2000.00, 2, 'available'),
('105', 'Standard Room', 'A basic room with essential amenities.', 2000.00, 2, 'available');

-- Insert Premium Rooms
INSERT INTO Rooms (room_number, room_type, room_description, room_price, room_capacity, room_status)
VALUES 
('201', 'Premium Room', 'A more spacious room with additional features.', 3500.00, 3, 'available'),
('202', 'Premium Room', 'A more spacious room with additional features.', 3500.00, 3, 'available'),
('203', 'Premium Room', 'A more spacious room with additional features.', 3500.00, 3, 'available'),
('204', 'Premium Room', 'A more spacious room with additional features.', 3500.00, 3, 'available'),
('205', 'Premium Room', 'A more spacious room with additional features.', 3500.00, 3, 'available');

-- Insert Deluxe Rooms
INSERT INTO Rooms (room_number, room_type, room_description, room_price, room_capacity, room_status)
VALUES 
('301', 'Deluxe Room', 'A luxurious room with top-notch facilities.', 5000.00, 4, 'available'),
('302', 'Deluxe Room', 'A luxurious room with top-notch facilities.', 5000.00, 4, 'available'),
('303', 'Deluxe Room', 'A luxurious room with top-notch facilities.', 5000.00, 4, 'available'),
('304', 'Deluxe Room', 'A luxurious room with top-notch facilities.', 5000.00, 4, 'available'),
('305', 'Deluxe Room', 'A luxurious room with top-notch facilities.', 5000.00, 4, 'available');

-- Insert Amenities
INSERT INTO Amenities (amenity_name, amenity_description, amenity_price, amenity_capacity, amenity_status)
VALUES
('Public Pool Access', 'A pool accessible by the hotel and resort patrons.', 500.00, 8, 'available'),
('Function Hall 1', 'A venue to hold celebrations and functions.', 10000.00, 1, 'available'),
('Function Hall 2', 'A venue to hold celebrations and functions.', 10000.00, 1, 'available'),
('Cottage 1', 'A small hut near the resort\'s pools.', 2000.00, 1, 'available'),
('Cottage 2', 'A small hut near the resort\'s pools.', 2000.00, 1, 'available'),
('Cottage 3', 'A small hut near the resort\'s pools.', 2000.00, 1, 'available'),
('Cottage 4', 'A small hut near the resort\'s pools.', 2000.00, 1, 'available'),
('Cottage 5', 'A small hut near the resort\'s pools.', 2000.00, 1, 'available'),
('Cottage 6', 'A small hut near the resort\'s pools.', 2000.00, 1, 'available');
