using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foo.v1.Time.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Create a database context to save a number of records
            using (var db = new TimeDbContext())
            {
                //Add a new time entity to the database collection, not this is not saved yet
                db.TimeEntities.Add(new TimeEntity
                {
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.Add(TimeSpan.FromHours(4)),
                    Comment = "This is a test comment"
                });
                //Add another time time entity to the database collection, note this is not saved yet 
                db.TimeEntities.Add(new TimeEntity
                {
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.Add(TimeSpan.FromHours(4)),
                    Comment = "This is a test comment"
                });
                //Commit the additions to the database#
                db.SaveChanges();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}