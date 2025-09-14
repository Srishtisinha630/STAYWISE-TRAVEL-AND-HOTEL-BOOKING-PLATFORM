🏨 StayWise – Travel and Accommodation Booking Platform API

This API provides endpoints for managing hotel-related tasks including booking, hotel and city management, guest services, and administrative operations.

✨ Key Features
🔐 User Authentication

User Registration – Create new accounts.

User Login – Secure login for registered users.

🌍 Global Hotel Search

Search hotels by name, room type, capacity, price range, and more.

Comprehensive results with hotel details.

🖼️ Image Management

Add, update, or delete images for cities, hotels, and rooms.

🏙️ Popular Cities

Display trending cities based on traffic.

📧 Email Notifications

Send booking confirmation emails with total price, hotel details, and location maps.

🛠️ Admin Interface

Full CRUD operations for cities, hotels, rooms, and owners.

📌 Endpoints Overview

The API includes endpoints for:

Amenities → /api/amenities

Auth → /api/auth/login, /api/auth/register-guest

Bookings → /api/user/bookings

Cities → /api/cities

Discounts → /api/room-classes/{roomClassId}/discounts

Guests → /api/user/recently-visited-hotels

Hotels → /api/hotels

Owners → /api/owners

Reviews → /api/hotels/{hotelId}/reviews

Room Classes & Rooms → /api/room-classes

🏗️ Architecture

Clean Architecture with Core and Infrastructure separation.

Layers:

Web (Controllers)

Infrastructure (DB, email, PDF, images, auth)

Application (Business logic)

Domain (Entities, rules)

⚙️ Tech Stack

C#, ASP.NET Core 8

Entity Framework Core with SQL Server

Firebase Storage for images

Swagger/OpenAPI for documentation

JWT for authentication

Serilog for logging

Design Patterns: Repository Pattern, Unit of Work, Options Pattern, RESTful API design

📑 API Versioning

Uses Asp.Versioning.Mvc

Clients specify version via x-api-version header.

🚀 Setup Guide
Prerequisites

.NET 8 SDK

SQL Server running locally or remotely

Steps
# Clone this repository
git clone https://github.com/Srishtisinha630/STAYWISE-TRAVEL-AND-HOTEL-BOOKING-PLATFORM.git

# Navigate into API folder
cd STAYWISE-TRAVEL-AND-HOTEL-BOOKING-PLATFORM/src/TABP.Api

# Run the project
dotnet run


Access API at: http://localhost:8080

Swagger UI: http://localhost:8080/swagger

🤝 Contributions

We welcome feedback, issues, and pull requests!

Report bugs via GitHub Issues.

Fork the repo and submit PRs for enhancements.

📬 Contact

👤 Maintainer: Srishti Sinha

📧 Email: srishtisinha630@gmail.com
