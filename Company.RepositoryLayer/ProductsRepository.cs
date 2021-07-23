using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.RepositoryContracts;
using Company.DomainModels;
using Company.DataLayer;

namespace Company.RepositoryLayer
{
    public class ProductsRepository : IProductsRepository
    {        
        CompanyDbContext db;

        public ProductsRepository()
        {
            this.db = new CompanyDbContext();
        }

        public List<Product> GetProducts()
        {
            List<Product> products = db.Products.ToList();
            return products;
        }

        public List<Product> SearchProducts(string ProductName)
        {
            List<Product> products = db.Products.Where(temp => temp.ProductName.Contains(ProductName)).ToList();
            return products;
        }

        public Product GetProductById(long ProductID)
        {
            Product product = db.Products.Where(temp => temp.ProductID == ProductID).FirstOrDefault();
            return product;
        }

        public void InsertProduct(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
        }

        public void UpdateProduct(Product p)
        {
            Product existingProduct = db.Products.Where(temp => temp.ProductID == p.ProductID).FirstOrDefault();
            existingProduct.ProductName = p.ProductName;
            existingProduct.Price = p.Price;
            existingProduct.DateOfPurchase = p.DateOfPurchase;
            existingProduct.CategoryID = p.CategoryID;
            existingProduct.BrandID = p.BrandID;
            existingProduct.AvailabilityStatus = p.AvailabilityStatus;
            existingProduct.Active = p.Active;
            existingProduct.Photo = p.Photo;
            db.SaveChanges();
        }
        public void DeleteProduct(long id)
        {
            Product existingProduct = db.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            db.Products.Remove(existingProduct);
            db.SaveChanges();
        }
    }
}

