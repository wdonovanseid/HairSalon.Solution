# _Hair Salon_

#### _Epicodus Project Clair's Salon, 10/9/2020_

#### By _**William Donovan-Seid**_

## Description

This project was built to help out with tracking bugs and help to remember trick from the past. User can add Project that they have worked on in the past or are working on now. Add Languages, so when you try and do something 2 years from now you can have reminders. Users can search the issue based on any word or fragment. In the issue you can add links to solutions or documentation, link the issue to projects and languages, and add the type or severity of the issue.

## Setup/Installation Requirements

### Project from GitHub
* Download option
  * Download files from GitHub repository by click Code and Download Zip
  * Extract files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * Have fun with HairSalon

* Cloning options
  * For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  * Place files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * Have fun with HairSalon

### Database Setup
* Setup with SQL statements 
  * Enter the following code into your SQL database and run.
  ``` SQL
  CREATE DATABASE `william_donovanseid` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
  USE 'william_donovanseid';
  CREATE TABLE `clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Details` varchar(255) DEFAULT NULL,
  `StylistId` int DEFAULT '0',
  PRIMARY KEY (`ClientId`)
  ) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Specialty` varchar(255) DEFAULT NULL,
  `Details` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
  ) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  ```
  * Go to appsettings.json and change the password if needed.

* Setup with SQL Import
  * MySQL
    * In the Navigator > Administration window, select Data Import/Restore.
    * In Import Options select Import from Self-Contained File.
    * Navigate to william_donovanseid.sql.
    * Under Default Schema to be Imported To, select the New button.
      * Enter 'william_donovanseid' as the name of your database.
      * Click Ok.
    * Click Start Import.
  * Go to appsettings.json and change the password if needed.

## Known Bugs

No Known Bugs

## Technologies Used

Main Programs
* MySQL
* C# / ASP.NET Core 
* MVC
* MSTest
* CSS
* Bootstrap


### Other Links
[GitHub](https://blog.agood.cloud/img/common/github.png)
[Will's GitHub](https://github.com/wdonovanseid)

### License

Copyright (c) 2020 **_{William Donovan-Seid}_**
Licensed under MIT