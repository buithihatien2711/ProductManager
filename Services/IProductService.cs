using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManager.Models;

namespace ProductManager.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();

        Product? GetProductByID(int id);

        void CreateProduct(Product product);

        void DeleteProduct(int id);

        void UpdateProduct(Product product);

        List<Category> GetCategories();
    }
}