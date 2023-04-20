# School Management System with ASP.NET Core 7 MVC

This repository contains the source code for a school management system built using ASP.NET Core 7 MVC. The project is designed to provide an educational resource for developers looking to build cross-platform web applications using the latest version of the .NET Core framework.

The project is a supporting repository for the course called "ASP.NET Core 7 MVC - Cross-Platform Development," which can be found at this URL: https://www.udemy.com/course/learn-aspnet-mvc-and-entity-framework/?referralCode=3B3CCAC77E3C70EF5B36.

## Table of Contents

- [Technologies](#technologies)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Features](#features)
- [Documentation](#documentation)
- [Contributing](#contributing)
- [License](#license)

## Technologies

The project uses the following technologies:

- ASP.NET Core 7 MVC
- Entity Framework Core
- SQL Server
- Bootstrap
- jQuery
- AutoMapper

## Getting Started

To get started with the project, follow these steps:

1. Clone the repository to your local machine.
2. Install the latest version of .NET Core SDK and SQL Server on your machine.
3. Update the connection string in the `appsettings.json` file with your SQL Server connection string.
4. Run the following commands in the root directory of the project to set up the database: `dotnet ef database update --project SchoolManagementSystem.Infrastructure --startup-project SchoolManagementSystem.Web`
5. Run the following command to start the web application: `dotnet run --project SchoolManagementSystem.Web`


## Project Structure

The solution is composed of the following projects:

- `SchoolManagementSystemApp`: Contains the MVC controllers, views, and data models.

## Features

The project includes the following features:

- Authentication and Authorization using OAuth and cookies
- CRUD operations for Students, Teachers, and Classes
- Search functionality for Students and Teachers
- Form Validation
- Exception handling middleware

## Documentation

The repository contains documentation for each of the features, including:

- An overview of the feature and its intended use case
- Installation and configuration instructions
- Code walkthroughs and explanations
- Best practices and tips for working with the feature

The documentation is designed to be accessible to developers of all skill levels, from beginners to advanced users.

## Contributing

Contributions to this repository are welcome. If you have a feature or educational resource that you would like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch for your changes.
3. Make your changes and commit them to your branch.
4. Submit a pull request.

Please ensure that your contributions adhere to the repository's code of conduct and that they are well-documented and follow best practices.

## License

This repository is licensed under the MIT License. See the [LICENSE](LICENSE) file for more information.


