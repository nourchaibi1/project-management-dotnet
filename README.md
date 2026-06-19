# Airport Management System

This project is a modular application designed to manage airport operations, including flights, planes, staff, and passengers. It serves as a practical implementation of **Clean Architecture** and **Domain-Driven Design (DDD)**, leveraging **LINQ** for data manipulation and **Entity Framework Core** for data modeling.

## 🏛 Domain Model & Class Structure

The application architecture is defined by the relationships visualized in **docs/diagramme_de_classe.png**, which highlights several key design patterns:

* **Polymorphic Inheritance:** The `Passenger` class serves as the base entity, with `Staff` and `Traveller` inheriting its properties, allowing for specialized handling of different user roles.
* **Association Mapping:** 
    * The system establishes a **0..1 to many** relationship between `Plane` and `Flight`.
    * A **Many-to-Many** relationship exists between `Flight` and `Passenger`, linked through the `Ticket` association class.
* **Enumerated Types:** The use of `PlaneType` (Boeing/Airbus) provides type safety for plane categorization.
* **Data Properties:** Entities are structured with specific types (e.g., `double` for prices, `DateTime` for scheduling, and `bool` for VIP status) to maintain data integrity across the system.

![Domain Model Class Diagram](docs/diagramme_de_classe.png)

## 🚀 Key Features

* **Flight Filtering:** Dynamically search and display flights by `Destination`, `FlightDate`, or `FlightId`.
* **Advanced LINQ Queries:** 
    * Sorting: `GetFlightsSortedByDuration` (Method & Query syntax).
    * Aggregation: `GetDurationsAverage` for operational analytics.
    * Projection: `GetDurationsInMinutes` demonstrating custom object mapping.
* **Mock Data Layer:** A `static` data engine that simulates complex database seeding for testing business logic.

## 🛠 Tech Stack

* **.NET 8**
* **C#**
* **LINQ (Language Integrated Query)**
* **Entity Framework Core**

## 📦 How to Run

1. Navigate to the project root folder.
2. Build the solution: `dotnet build`
3. Run the application: `dotnet run`

---
*Developed as part of an Advanced Software Engineering lab to demonstrate enterprise-grade application structure.*