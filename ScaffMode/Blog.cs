using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffMode
{
    public partial class Blog
    {
        public Blog()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public int BrowseTimes { get; set; }
        public string Url { get; set; }
        public string Auth { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastUpdateTime { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
