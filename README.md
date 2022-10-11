# EcommAPI
## About the project
In this project we are aiming to build a .NET Core 6 based E-Commerce web application that is built with onion architecture.  
## DAY 1
The first day of the project we;
 1. Opened a blank ".NET Core 6" Project and created the needed subfolders, API and Class Libraries,
 2. Created [Products.cs](/Core/EcommAPI_Domain/Entities/Common/Product.cs) under Entities folder and added "Name, StockNumber and Price variables,  
 3. Created [ProductService.cs](/Infrastructre/EcommAPI_Persistance/Concretes/ProductService.cs) under Concretes folder and created GetProducts as a Product type List and added 4 dummy variables,
 4. Created [IProductService.cs](/Core/EcommAPI_Application/Abstractions/IProductService.cs) under Abstractions folder and added IProductService interface then added GetProducts as a Product type List
 5. Created [Products Controller](/Presentation/EcommAPI_API/Controllers/ProductsController.cs) and added Public GetProducts method,
 6. Created [ServiceRegisiration.cs](/Infrastructre/EcommAPI_Persistance/ServiceRegistration.cs) under Persistance Class Library and created an instance of [IProductService](/Core/EcommAPI_Application/Abstractions/IProductService.cs) with dummy variables inside [ProducService](/Infrastructre/EcommAPI_Persistance/Concretes/ProductService.cs), 
 7. Added the created instance to builder of the API under [Program.cs](/Presentation/EcommAPI_API/Program.cs). <br>
Note: The folder links are organized according to the onion architecture.
