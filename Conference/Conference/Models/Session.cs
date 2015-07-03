using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Models
{

    public class Session
    {

        public int SessionId { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public int SpeakerId { get; set; }
        public virtual Speaker Speaker { get; set; }

    }

}
