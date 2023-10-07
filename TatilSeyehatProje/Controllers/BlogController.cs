using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyehatProje.Models.Entities;

namespace TatilSeyehatProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context db = new Context();
        BlogComment bc = new BlogComment();
        public ActionResult Index()
        {
            //var values = db.Blogs.ToList();
            bc.Deger1 = db.Blogs.ToList();
            bc.Deger3 = db.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(bc);
        }
        
        public ActionResult BlogDetail(int id)
        {
            bc.Deger1= db.Blogs.Where(x => x.ID == id).ToList();
            bc.Deger2 = db.Comments.Where(x => x.Blogid == id).ToList();
            bc.Deger3 = db.Blogs.Take(3).ToList();

            //var values = db.Blogs.Where(x => x.ID == id).ToList();
            return View(bc);
        }
       [HttpGet]
       public PartialViewResult CommentAdd(int id)
        {
            ViewBag.values = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult CommentAdd(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
            return PartialView();
        }
    }
}