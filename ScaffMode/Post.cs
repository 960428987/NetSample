using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffMode
{
    public partial class Post
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? UserIdAuthor { get; set; }
        public int? ContributorId { get; set; }

        public string BlogUrl { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual User Contributor { get; set; }
        public virtual User UserIdAuthorNavigation { get; set; }
    }
}
