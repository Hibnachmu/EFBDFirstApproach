# Online shopping site prototype. (Built using ASP.NET MVC)

This is my work in progress .NET project that I have been working on with respect to my ongoing certification course. 

## What this project actually is?

As the title suggests, this is a prototype of an online shopping site where ideally, one could login as a customer to see the various products that are available on the site, or login as a Manager to manage the various products that are available on the site (to change the status of products) or login as the administrator to have an overall control over the site. 
This application, as of now, is built using two databases in MS SQL (one to keep the products and one to keep tabs of the users).

## Features included till date:
Some of the building blocks and functionalities included in this project are:
 - This site was built using tools such as Bootstrap, jQuery and popper.js.
 - The code demonstrates the use of Razor view engine, the organization of View such as Shared views, Layout views, etc.
 - The concepts of URL routing - parameter routing, resolving conflicts between routes and using attribute routing.
 - This prject was first built using the *"Database first approach"*. The database was created using Microsoft Server Management studio 18.
 - Later on, to learn about the concepts of Migrations and using the *"Code first approach"*, the database was deleted and then recreated using Models.
 - To learn the concept of HTML helpers, some of the views were rewritten using HTML helpers. 
 - The functionality to validate a form (Blank forms cannot be submitted).
 - Currently working on ASP.NET Identity (allowing the facility to login, organize the different types of users, setting up the work areas).
 
 ## Packages installed using the Nuget package manager:
 
 ```sh 
 install-package bootstrap
 ```
 
 ```sh
 install-package jQuery
 ```
 
 ```sh
 install-package popper.js
 ```
 
 ```sh
 install-package jQuery.Validation
 ```
 
 ```sh
 install-package Microsoft.jQuery.unobtrusive.Validation
 ```
 
 ```sh
 install-package Microsoft.AspNet.Identity.EntityFramework
 ```
 
 ```sh
 install-package Microsoft.Aspnet.Identity.Owin
 ```
 
 ```sh
 install-package Microsoft.Owin.Host.SystemWeb
 ```
 
 ## Future work:
 Some of the things that I'd be implementing soon would be:

- Creating and managing areas
- Using Filters.
- Security.
- Exceptiong handling in MVC.
- Service pattern and repository pattern.
- State Management.
- AJAX and WebAPI
