﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDbFirstApproachExample.Identity;
using EFDbFirstApproachExample.Filters;

namespace EFDbFirstApproachExample.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class UsersController : Controller
    {
        // GET: Admin/Users/Index
        public ActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<ApplicationUser> existingUsers = db.Users.ToList();

            return View(existingUsers);
        }
    }
}