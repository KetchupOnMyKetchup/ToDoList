# End-to-end from Code Project, to VSTS CI/CD, to Azure
This is a simple proof of concept to display an Azure App Service website communicating with an API project, which communicates to an Azure SQL back-end. The app is a To-Do application based on Microsoft's To-Do List app, but adapted for Azure deploy and to Visual Studio 2017. The project's technology stack is C#, Angular JS, and SQL. The full tutorial is located here: https://github.com/catenn/ToDoList

![alt text](https://github.com/catenn/ToDoList/blob/master/Images/todolist-diagram.png)

The walkthrough is an 8-part series that will start you with a Visual Studio project to download that is fully functional.  You will learn how to set up the project on your local machine and test it out.  Along the way, I will go through how to use Swagger for your APIs and Dapper for the back-end micro-ORM to communicate with the database.  We will use Git to push code into Visual Studio Team Services (VSTS).  Then we will use VSTS to complete a Build process (Continuous Integration) which will create an artifact that can be then pushed to a Release process (Continuous Delivery) which will deploy it to Azure.  On average, it should take you 2-4 hours to complete the entire tutorial.  All of it can be done for free with free software and subscriptions, all details are in the tutorial itself! 


# Tutorial Sections: 
* **[00 Prerequisites, Timing, and Cost:](https://github.com/catenn/ToDoList/wiki/00.-Prerequisites,-Timing,-and-Cost)** I will explain all of the software and accounts required to complete this tutorial. 
* **[01 Local Setup:](https://github.com/catenn/ToDoList/wiki/01.-Local-Setup)** Locally connect a front-end website to an API, and connect the API to a SQL Server. I will explain enough for you to get a local database setup and get the app up and running on your local machine. 
* **[02 Swagger (optional):](https://github.com/catenn/ToDoList/wiki/02.-Swagger)** Learn how to use Swagger for API management
* **[03 Dapper (optional):](https://github.com/catenn/ToDoList/wiki/03.-Dapper)** Learn how to use Dapper micro-ORM to access to database
* **[04a Azure Deployment (manual):](https://github.com/catenn/ToDoList/wiki/04a.-Azure-Deployment-(Azure-SQL))** Deploy the SQL database to Azure manually
* **[04b Azure Deployment (manual):](https://github.com/catenn/ToDoList/wiki/04b.-Azure-Deployment-(App-Services:-Web-App-&-API-App))** Deploy the front-end Web App and API App to Azure manually
* **[05 Adding project to VSTS with Git:](https://github.com/catenn/ToDoList/wiki/05.-Adding-project-to-VSTS-with-Git)** I will show you how create a free VSTS account and how to use Git to add your project to VSTS
* **[06 VSTS Continuous Integration:](https://github.com/catenn/ToDoList/wiki/06.-VSTS-Continuous-Integration-(Build-Definition))** Setup a CI Process in VSTS 
* **[07 VSTS Continuous Deployment:](https://github.com/catenn/ToDoList/wiki/07.-VSTS-Continuous-Deployment-(Release-Definitions))** Setup a CD Process in VSTS (automated deploy to Azure)
* **[08 Cleanup:](https://github.com/catenn/ToDoList/wiki/08.-Cleanup)** Cleanup and delete the Azure resources created in this tutorial. 

