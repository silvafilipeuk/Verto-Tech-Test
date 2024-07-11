Project created as a tech test for the company Verto.

- C# Web MVC application that implement a home page for a website.

- Responsiveness using Foundation CSS


To reproduce the project locally:

- git clone https://github.com/silvafilipeuk/Verto-Tech-Test.git


- Open the project in the Microsoft Visual Studio code 2022

- Create a Database in your SQL SERVER.

- Update appsettings.json with your SQL Server address, and Database name as per line below:

- "DefaultConnection": "Server=YOUR_SERVER_HERE;Database=YOUR_DATABASE_NAME_HERE;Trusted_connection=true;TrustServerCertificate=true;"

- On the Package Manager Console:

- Add-Migrations Seeding_database

- update-database (will create and seed the database) 

- Run the application with Visual Studio Code.
