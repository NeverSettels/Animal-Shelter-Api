# _Animal Shelter Api_

#### _June 12th. 2020_

#### By: _**Eric Settels**_

## Description

This ia an Animal shelter Api with Full CRUD functionality.

Api has the following end points:

_GET /api/Animal => returns list of animals Queriable by, name, species, gender, age and hasSpecialMedicalNeeds._

_POST /api/Animal => post new Animal._

_GET /api/Animal/{id} => Returns one animal with matching ID._

_PUT /api/Animal/{id} => Edits one Animal With Matching ID._

_DELETE /api/Animal/{id} => Deletes one Animal With Matching ID._

_GET /api/Animal/random => Returns one Random Animal._

_GET /api/Animal/page={page} => Returns paginated results with 3 Animals per page (for easy visualisation with Seeded
data)_

Too see more details follow **Setup/Installation Requirements** and use the Swager UI at endpoint /index.html.

## Support

_The software is provided as is. It might work as expected - or not. Use at your own risk._

## Built With

- HTML
- Enity
- Sashbuckle
- Razor
- C#

## Setup/Installation Requirements

### Note: this app requires MySql Workbench

- _First, clone this repository to your desktop by navigating to the desktop in the Terminal (entering "cd desktop" in
  the Terminal) and then entering "git clone" followed by the url to this repository._
- _Once the project directory is cloned to your desktop, navigate to the directory in the terminal by entering "cd"
  followed by the name of this repository in the Terminal._
- _Confirm that you have navigated to the project directory by entering "pwd" in the Terminal._
- _Once the project directory is cloned to your desktop, navigate VendorTracker file in the terminal by entering "cd
  VendorTracker" followed by the name of this repository in the Terminal._
- _Once you have navigated to the directory in the terminal, open the contents of the directory in a text editor or IDE
  of your choice (e.g., to open the contents of the directory in Visual Studio Code, enter the command "code ." in the
  Terminal)._
- _Open the terminal within and run the command "dotnet restore", then "dotnet ef migrations add SomeUniqueName"
  followed by "dotnet ef database update" to build the api and seed some starter Data._
- _Open the terminal within and run the command "dotnet run", to start up the server._
- _Navigate to http://localhost:5000/ in here you will see detailed Documentation for this API and you can play to your
  hearts content!_

## Bugs

_No known bugs at this time._

### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Eric Settels_**
