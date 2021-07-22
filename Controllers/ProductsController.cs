﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDbFirstApproachExample.Models;
using EFDbFirstApproachExample.Filters;

namespace EFDbFirstApproachExample.Controllers
{   
    public class ProductsController : Controller
    {
        // GET: Products/Index
        [MyAuthenticationFilter]
        [CustomerAuthorization]
        [MyExceptionFilter]
        public ActionResult Index()
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Product> products = db.Products.ToList();            
            return View(products);
        }

        [ChildActionOnly]
        public ActionResult DisplaySingleProduct(Product p)
        {
            return PartialView("MyProduct", p);
        }
    }
}