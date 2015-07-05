using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Models
{

    public class Speaker
    {
        [Key]
        public int SpeakerId { get; set; }
        [Required(),
        Display(Name = "Speaker")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress),
        Display(Name = "Email")]
        public string EmailAddress { get; set; }
        //public virtual List<Session> Sessions { get; set; }
    }

}
