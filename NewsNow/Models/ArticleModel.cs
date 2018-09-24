﻿using System;

namespace NewsNow.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        public DateTime? DateCreated { get; set; }

        public string Header { get; set; }

        public string Summery { get; set; }
        
        public string Content { get; set; }

        public string HomeImageUrl { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}