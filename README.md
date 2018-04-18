# Introduction and Welcome
This is a simple proof of concept to display an Azure App Service website communicating with an API project, which communicates to an Azure SQL back-end. The app is a To-Do application based on Microsoft's To-Do List app, but adapted for Azure deploy and to Visual Studio 2017. The project's technology stack is C#, Angular JS, and SQL. The project was originally forked from a Microsoft documentation page that has now been depreciated. 

The process for the app is diagrammed below.  In Visual Studio, you will start out with a working To Do list application.  You will push the code to VSTS (Visual Studio Team Services).  Then you will create a CI/CD (Continuous Integration/Continuous Delivery) process in order to deploy to Azure. In Azure you will create 3 resources: Azure Web App, Azure API App, and an Azure SQL Server. 
![alt text](https://github.com/catenn/ToDoList/blob/master/Images/todolist-diagram.png)
The application will be built and working when you download it.  The tutorial will not teach you how to code, but how to set it up and deploy it.  You are welcome to use it as a base for your own apps, for learning purposes, or anything you like. If you want to learn how to build the APIs from scratch, please go [here](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api).

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

# Tutorial Partial Paths:
The tutorial can be completed in full, or partially. Here are the partial paths: 
* If you are uninterested in Azure or are a junior developing learning to code to simply go through **Parts 01-03** to understand how applications are setup with a front end to an API layer to a SQL Database.  
* If you are seeking to learn Azure and the CI/CD process (and you already know Swagger and Dapper), you can do **Parts 01 and 04-07** (skip 02-03).  
* If you are seeking to learn Azure and the CI/CD process, and you already know how to deploy to Azure manually and are only interested in the CI/CD process (and you already know Swagger and Dapper), you can do **Parts 01, 04a, [create empty web app/api resources](https://github.com/catenn/ToDoList/wiki/Reference:-Deploying-resources-to-Azure-(App-Services)), and 06-07**.  

_Note: Parts 02-03 are optional and purely informational if you would like to learn how to use Swagger or Dapper. Swagger is a useful tool for API management and testing by directly accessing the API endpoints. Dapper is a micro-ORM that is very lightweight and makes accessing the database faster with much less code. No code changes are made during these steps, they are informational and explanatory only._


_Please contact me at catenn@gmail.com with any issues and I will do my best to keep updating this tutorial. If this helped you at all and you enjoyed it, please star the repo! Would really appreciate it =)_
