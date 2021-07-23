﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.ServiceContracts;
using Company.DataLayer;
using Company.DomainModels;
using Company.RepositoryContracts;
using Company.RepositoryLayer;

namespace Company.ServiceLayer
{
    public class ProductsService: IProductService
    {
        IProductsRepository prodRep;
        
        public ProductsService(IProductsRepository r)
        {
            this.prodRep = r;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = prodRep.GetProducts();
            return products;
        }

        public List<Product> SearchProducts(string ProductName)
        {
            List<Product> products = prodRep.SearchProducts(ProductName);
            return products;
        }

        public Product GetProductById(long ProductID)
        {
            Product product = prodRep.GetProductById(ProductID);
            return product;
        }

        public void InsertProduct(Product p)
        {
            if (p.Price <= 1000000)
            {
                prodRep.InsertProduct(p);
            }
            else
            {
                throw new Exception("Price exceeds the limit of 1000000");
            }            
        }

        public void UpdateProduct(Product p)
        {
            prodRep.UpdateProduct(p);
        }
        public void DeleteProduct(long id)
        {
            prodRep.DeleteProduct(id);
        }
    }
}