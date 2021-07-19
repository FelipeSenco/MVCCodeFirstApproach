using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDbFirstApproachExample.Models;

namespace EFDbFirstApproachExample.Controllers
{
    public class UsersController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            CompanyDbContext db = new CompanyDbContext();
            List<User> users = db.Users.ToList();
            return View(users);
        }

        public ActionResult Create()
        {
            CompanyDbContext db = new CompanyDbContext();            
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "UserID, FirstName, LastName, Mobile, Email, Photography, Gardening, Dance, Hiking, Painting")] User u)
        {
            CompanyDbContext db = new CompanyDbContext();
            if (ModelState.IsValid)
            {              
                db.Users.Add(u);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {               
                return View();
            }
        }

        public ActionResult Delete(long id)
        {
            CompanyDbContext db = new CompanyDbContext();
            User u = db.Users.Where(temp => temp.UserID == id).FirstOrDefault();
            return View(u);
        }

        [HttpPost]
        public ActionResult Delete(User u)
        {
            CompanyDbContext db = new CompanyDbContext();
            User existingUser = db.Users.Where(temp => temp.UserID == u.UserID).FirstOrDefault();
            db.Users.Remove(existingUser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}