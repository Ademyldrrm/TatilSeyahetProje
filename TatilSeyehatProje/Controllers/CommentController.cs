using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyehatProje.Models.Entities;

namespace TatilSeyehatProje.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Comments.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CommentUpdate(int id)
        {
            var values = db.Comments.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult CommentUpdate(Comment comment)
        {
            var values = db.Comments.Find(comment.ID);
            values.UserName = comment.UserName;
            values.Mail = comment.Mail;
            values.Comments = comment.Comments;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteComment(int id)
        {
            var values = db.Comments.Find(id);
            db.Comments.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}