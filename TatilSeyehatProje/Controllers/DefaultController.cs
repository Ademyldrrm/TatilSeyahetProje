using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyehatProje.Models.Entities;

namespace TatilSeyehatProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Blogs.OrderByDescending(x=>x.ID).Take(4).ToList();
            return View(values);
        }
        public PartialViewResult Partial1()
        {
            var values = db.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var values = db.Blogs.OrderByDescending(x => x.ID).Take(10).ToList();
            return PartialView(values);
        }
        public PartialViewResult Parrtial3()
        {
            var values = db.Blogs.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult Parrtial4()
        {
            var values = db.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial5()
        {
            var values = db.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(values);
        }
    }
}