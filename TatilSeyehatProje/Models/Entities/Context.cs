using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TatilSeyehatProje.Models.Entities
{
    public class Context:DbContext
    {

        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdressBlog> AdressBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}