using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class Book
    {
        public Guid Bid { get; set; }
        public string BookName { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
