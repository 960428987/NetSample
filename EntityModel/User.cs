using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

       // [InverseProperty(nameof(Post.Author))]//反转导航属性
        public List<Post> AuthoredPost { get; set; }

       // [InverseProperty(nameof(Post.Contributor))]//反转导航属性
        public List<Post> ContributedToPosts { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        [ConcurrencyCheck]//并发检查
        public double balance { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
