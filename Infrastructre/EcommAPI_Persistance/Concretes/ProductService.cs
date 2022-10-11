using EcommAPI_Application.Abstractions;
using EcommAPI_Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommAPI_Persistance.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new()
        {
            new() {Id = 1, Name = "Product 1", CreateDate=DateTime.Now, Price=200, StockNumber=30 },
            new() {Id = 2, Name = "Product 2", CreateDate=DateTime.Now, Price=200, StockNumber=30 },
            new() {Id = 3, Name = "Product 3", CreateDate=DateTime.Now, Price=200, StockNumber=30 },
            new() {Id = 4, Name = "Product 4", CreateDate=DateTime.Now, Price=200, StockNumber=30 },
        };
    }
}
