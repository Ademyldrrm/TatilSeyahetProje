﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyehatProje.Models.Entities
{
    public class BlogComment
    {
        public IEnumerable<Blog>Deger1 { get; set; }
        public IEnumerable<Comment> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
    }
}