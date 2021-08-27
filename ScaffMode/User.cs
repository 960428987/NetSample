using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffMode
{
    public partial class User
    {
        public User()
        {
            PostContributors = new HashSet<Post>();
            PostUserIdAuthorNavigations = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual ICollection<Post> PostContributors { get; set; }
        public virtual ICollection<Post> PostUserIdAuthorNavigations { get; set; }
    }
}
