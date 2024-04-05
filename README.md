# Car Rental System

A comprehensive C# project utilizing Windows Forms and Access Database to facilitate car rental processes. Designed with a focus on user experience, the system features four main forms - Car Rental Main Screen, Cars Information, Book Your Car, and View Receipt - and utilizes an Access database comprising three tables: CarsData, CustomerInfo, and Bookings.

[User Manual](CarRental-Manualv2.pdf):

## Table of Contents

- [Introduction](#introduction)
- [Setup](#setup)
- [Usage](#usage)
  - [Car Rental Main Screen](#car-rental-main-screen)
  - [Cars Information](#cars-information)
  - [Book Your Car](#book-your-car)
  - [View Receipt](#view-receipt)
- [Database Schema](#database-schema)
  - [CarsData](#carsdata)
  - [CustomerInfo](#customerinfo)
  - [Bookings](#bookings)
- [Code Structure](#code-structure)
  - [Form1: Car Rental Main Screen](#form1-car-rental-main-screen)
  - [FormCarInfo: Cars Information](#formcarinfo-cars-information)
  - [FormBooking: Book Your Car](#formbooking-book-your-car)
  - [FormReceipt: View Receipt](#formreceipt-view-receipt)
- [Contributing](#contributing)
- [License](#license)

## Introduction

This project is developed in C# using Windows Forms, designed to enable customers to rent cars of their choice conveniently. The application interacts with an Access database to store and retrieve information related to cars, customers, and bookings.

## Setup

1. Install Visual Studio with C# and Windows Forms development components. I am using v2019.
2. Clone the repository to your local machine.
3. Open the solution in Visual Studio.
4. Ensure Access Database Engine is installed on your system to interact with the Access database.
5. Run the project from Visual Studio.

## Usage

### Car Rental Main Screen

The application's main screen displays available cars and allows users to select a car for more information or to initiate a rental process.

### Cars Information

Displays detailed information about the selected car, including rental rates, features, and images.

### Book Your Car

Enables users to enter their information and book a car for rental. Validates user input and stores booking details in the database.

### View Receipt

Generates a receipt for the user after a successful booking, showing detailed information about the rental.

## Database Schema

### CarsData

Stores information about cars available for rent. Fields include CarID, CarModel, StockQuantity, and CostPerDay.

### CustomerInfo

Holds customer details entered during the booking process. Fields include CustomerID, FirstName, LastName, TelephoneNumber, and CardNumber.

### Bookings

Records details of car bookings. Fields include BookingID, CarID, CustomerID, PickupDate, DropOffDate, and TotalCost.

## Code Structure

Brief descriptions of the forms and their key functionalities.

### Form1: Car Rental Main Screen

Main application window displaying available cars and navigation options.

### FormCarInfo: Cars Information

Form showing detailed information about a selected car.

### FormBooking: Book Your Car

Form for entering customer information and booking details.

### FormReceipt: View Receipt

Displays a receipt with booking and customer information.

## Contributing

Instructions for how others can contribute to the project.

## License

Arpit Sondhi. All Rights Reserved. 
