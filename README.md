# Clean Architecture with CQRS & MediatR Pattern

## Overview

This project serves as a boilerplate template for implementing the Clean Architecture with CQRS & MediatR Pattern using .NET 8. The Clean Architecture provides a robust and flexible software design that easily adapts to changes and maintains high maintainability. CQRS (Command Query Responsibility Segregation) pattern divides the application into two parts: Commands for modifying the state and Queries for retrieving data. MediatR acts as a centralized communication hub, ensuring that all handler invocations from the controller go through it. This separation of concerns enables scalability and performance optimization.

## Getting Started

Follow these instructions to set up and run the project on your local machine for development and testing.

### Prerequisites

- .NET 8 SDK
- Visual Studio 2022 or Visual Studio Code

### Installation Steps

1. Clone the repository:

    ```bash 
    git clone https://github.com/5ajish/CleanArchitecture.git
    ```

2. Open the solution file `CleanArchitecture.sln` in Visual Studio.

3. Change the connection string in the `appsettings.json` file.

4. In the Package Manager Console, set `CleanArchitecture.Persistence` as the Default Project and run the command `update-database`. This creates the database locally.

5. Build and run the solution.

## Architecture

The Clean Architecture with CQRS Pattern consists of the following layers:

- **WebAPI Layer:** Presentation layer containing user interface components. Handles user input and displays output.
  
- **Application Layer:** Core layer with business logic. Coordinates use cases (features) using commands and queries. Communicates with the Domain Layer.

- **Domain Layer:** Core layer with entities and business logic. Defines rules and behaviors of the application.

- **Persistence Layer:** Contains implementation details. Communicates with external systems and services. Infrastructure Layer communicates with the Application Layer using repositories and data access objects.

## Technologies Used

- .NET 8
- ASP.NET Core
- Entity Framework Core
- CQRS and MediatR
- FluentValidation
- AutoMapper
- xUnit

## License

This project is licensed under the MIT License - see the [License.md](License.txt) file for details.
