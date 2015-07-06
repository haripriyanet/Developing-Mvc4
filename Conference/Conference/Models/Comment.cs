using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Models
{

    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public int SessionId { get; set; }
        public virtual Session Session { get; set; }
    }

}
