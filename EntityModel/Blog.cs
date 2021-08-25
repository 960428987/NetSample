using System;
using System.Collections.Generic;

namespace EntityModel
{
    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
