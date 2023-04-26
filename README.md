<h1>Login Page</h1> 

## Project description

<p align="justify">
    This is a web application project that focuses on implementing a simple login functionality in ASP.NET Core MVC using C#. It provides a foundation for building secure and authenticated web applications. The project includes a LoginController, UserModel, SecurityService, and UsersDAO to handle user authentication and authorization.
</p>

## Getting Started

<p align="justify">
    To run the project locally, follow these steps:

    1. Clone the repositoryto your local machine.
    2. Open the solution in Visual Studio or any other compatible IDE.
    3. Update the connection string in the 'UsersDAO' class to point to your SQL Server instance.
    4. Build and run the application.
    5. Access the application in your web browser and navigate to the login page.
    6. Enter a valid username and password to login and see the login success view, or enter an invalid username or password to see the login failure view.
</p>

## Features

<p align="justify">

    • Login form: The project includes a login form with fields for username and password input.
    • Login success view: When a valid username and password are entered, the user is redirected to a login success view which displays the user's information, including user ID, username, and password.
    • Login failure view: When an invalid username or password is entered, the user is redirected to a login failure view which displays the incorrect user information.
    • Data Access Object (DAO): The project includes a DAO class ('UsersDAO') that communicates with the database to retrieve user information.
    • Security service: The project includes a security service class ('securityservice') that validates user credentials by calling the 'IsValid' method in the 'UsersDAO' class.
    • Model class: The project includes a model class ('UserModel') that represents the user entity and holds user information.

</p>

## Technologies Used

<p align="justify">

    • C#: The project is written in C#, which is a modern, object-oriented programming language used for developing applications on the Microsoft .NET platform.
    • ASP.NET Core MVC: The project is built using ASP.NET Core MVC framework, which provides a structured and modular approach for building web applications.
    • Microsoft SQL Server: The project uses Microsoft SQL Server as the relational database management system for storing user information.

</p>

Copyright :copyright: 2023 - Login Page
