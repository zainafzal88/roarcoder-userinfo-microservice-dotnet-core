# roarcoder-userinfo-microservice-dotnet-core
Create a Web API for user information of my personal [website](https://roarcoder.dev).

## Getting Started
1.  Familiarity with C#, Model-View-Controller (MVC), Entity Framework, PostgreSQL and Docker
2.  Visual Studio For Mac
3.  Postman
4.  DBeaver (Database Management Tool)
5.  Docker

## Running
1.  Make sure the docker is running
2.  Clone or download the zip folder
3.  Nagivate to the project folder
4.  Add NuGet Packages
```
dotnet add package NpgSql.EntityFrameworkCore.PostgreSQL.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool install --global dotnet-aspnet-codegenerator
```
5.  Run the below command in the root of the project folder. It will start all the docker services
```
docker-compose up
```
6.  Open up DBeaver and connect to the database.
7.  Create a table and add personal information outlined in `UserInfo.cs`
8.  Come back to VS.
9.  Build the project
10. Go to Run -> Run With -> Custom Configuration -> ASP.NET Core
11. Change App Url to `http://localhost:<port-number>/api/userinfo`
12. You should see the personal information read from the database