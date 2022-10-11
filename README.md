# EcommAPI
## About the project
In this project we are aiming to build a .NET Core 6 based E-Commerce web application that is built with onion architecture.  
## DAY 1
The first day of the project we;
 -Opened a blank ".NET Core 6" Project and created the needed subfolders, API and Class Libraries,
 -Created [Produts.cd](/Core/EcommAPI_Domain/Entities/Common/Product.cs) under Entities folder and added "Name, StockNumber and Price variables,  
 -Created [ProductService.cs](/Infrastructre/EcommAPI_Persistance/Concretes/ProductService.cs) under Concretes folder and created GetProducts as a Product type List and added 4 dummy variables,
 -Created [IProductService.cs](/Core/EcommAPI_Application/Abstractions/IProductService.cs) under Abstractions folder and added IProductService interface then added GetProducts as a Product type List
 -Created [Products Controller](/Presentation/EcommAPI_API/Controllers/ProductsController.cs) and added Public GetProducts method,
 -Created [ServiceRegisiration.cs](/Infrastructre/EcommAPI_Persistance/ServiceRegistration.cs) under Persistance Class Library and created an instance of [IProductService](/Core/EcommAPI_Application/Abstractions/IProductService.cs) with dummy variables inside [ProducService](/Infrastructre/EcommAPI_Persistance/Concretes/ProductService.cs), 
-Added the created instance to builder of the API under [Program.cs](/Presentation/EcommAPI_API/Program.cs).
Note: The folder links are organized according to the onion architecture.