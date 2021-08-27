using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
  public  class Post
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public User Author { get; set; }
        public User Contributor { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
