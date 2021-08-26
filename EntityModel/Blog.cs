using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityModel
{
    public class Blog
    {
        public int Id { get; set; }

        public int BrowseTimes { get; set; }

        public string Url { get; set; }

        public string Auth { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
