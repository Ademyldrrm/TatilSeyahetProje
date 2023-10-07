using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyehatProje.Models.Entities;

namespace TatilSeyehatProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context db = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
            db.Blogs.Add(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var values = db.Blogs.Find(id);
            db.Blogs.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult BlogUpdate(int id)
        {
            var values = db.Blogs.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult BlogUpdate(Blog blog)
        {
            var values = db.Blogs.Find(blog.ID);
            values.Title = blog.Title;
            values.Date = blog.Date;
            values.Description = blog.Description;
            values.BlogImage = blog.BlogImage;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}