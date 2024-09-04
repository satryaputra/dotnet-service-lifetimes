# .NET Dependency Injection Example

This project demonstrates a basic .NET application using dependency injection with different service lifetimes. The application sets up a simple web server with a single endpoint that provides information about various service instances.

## Overview

The application configures three types of services with different lifetimes:

- **Singleton**: A single instance of the service is created and shared throughout the application.
- **Scoped**: A new instance of the service is created for each request within a given scope.
- **Transient**: A new instance of the service is created every time it is requested.

### Running the Application

To run the application, execute the project using the .NET CLI or through Visual Studio. Navigate to the root URL (`/`) to view the service instance details.

## References

For more information on the differences between Singleton, Scoped, and Transient lifetimes, refer to [Grant Winney's blog post](https://grantwinney.com/difference-between-singleton-scoped-transient/).