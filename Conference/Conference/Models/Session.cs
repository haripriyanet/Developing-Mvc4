using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Models
{

    public class Session
    {
        [Key]
        public int SessionId { get; set; }
        [Required()]
        public string Title { get; set; }
        [Required(),
        DataType(DataType.MultilineText)]
        public string Abstract { get; set; }
        public int SpeakerId { get; set; }
        public virtual Speaker Speaker { get; set; }
    }

}
