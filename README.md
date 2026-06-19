# ✈️ Airport Management System

> A .NET 8 console application for managing airport operations — flights, planes, staff, and passengers — built as a practical exercise in **Clean Architecture**, **Domain-Driven Design**, and **Entity Framework Core**.

---

## Tech Stack

![.NET](https://img.shields.io/badge/.NET_8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![EF Core](https://img.shields.io/badge/Entity_Framework_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![LINQ](https://img.shields.io/badge/LINQ-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

---

##  Domain Model

```mermaid
classDiagram
    class Plane {
        +int PlaneId
        +int Capacity
        +DateTime ManufactureDate
        +PlaneType PlaneType
    }

    class Flight {
        +int FlightId
        +string Departure
        +string Destination
        +DateTime FlightDate
        +DateTime EffectiveArrival
        +float EstimatedDuration
    }

    class Ticket {
        +double Price
        +int Seat
        +bool VIP
    }

    class Passenger {
        +string FirstName
        +string LastName
        +DateTime BirthDate
        +string EmailAddress
        +string PassportNumber
        +string TelNumber
    }

    class Staff {
        +DateTime EmployementDate
        +string Function
        +double Salary
    }

    class Traveller {
        +string HealthInformation
        +string Nationality
    }

    class PlaneType {
        <<enumeration>>
        Boeing
        Airbus
    }

    Plane "0..1" --> "*" Flight : operates
    Flight "*" --> "*" Passenger : via Ticket
    Ticket --> Flight
    Ticket --> Passenger
    Passenger <|-- Staff
    Passenger <|-- Traveller
    Plane --> PlaneType
```

---

##  Architecture

The project follows a clean **N-Tier Layered Architecture** with strict separation of concerns:

| Layer | Project | Responsibility |
|---|---|---|
| Domain | `AM.ApplicationCore` | Entities, business rules |
| Application | `AM.ApplicationCore` | Interfaces (`IBasicFlightService`), service orchestration |
| Infrastructure | `AM.Infrastructure` | EF Core `DbContext`, data access, migrations |
| Presentation | `AM.UI.Console` | Entry point, dependency injection |

> Swapping from in-memory data to SQL Server, or from a console UI to a Web API, only touches the outer layers — the core business logic stays untouched.

---

##  Features

-  **Flight filtering** by destination, date, or ID
-  **LINQ queries** — sorting, aggregation, and projection (method & query syntax)
-  **Duration analytics** — average duration, durations in minutes
-  **Mock data layer** — in-memory seeding for testing business logic
-  **EF Core** — Migrations, Fluent API configuration, lazy & eager loading

---

##  Project Structure

```
AirportManagement/
├── AM.ApplicationCore/       # Domain entities + service interfaces
├── AM.Infrastructure/        # EF Core DbContext + data access
├── AM.UI.Console/            # Console entry point
└── docs/
    └── diagramme_de_classe.png
```

---

##  Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)

### Run

```bash
git clone <repo-url>
cd AirportManagement
dotnet build
dotnet run --project AM.UI.Console
```

---

##  Class Diagram

![Domain Model Class Diagram](docs/diagramme_de_classe.png)

---

*Developed as part of an Advanced Software Engineering lab to demonstrate enterprise-grade application structure.*
