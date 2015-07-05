using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Conference.Models
{
    public class Speaker
    {
        public int SpeakerId { get; set; }
        [Display(Name="Speaker")]
        public string Name { get; set; }
        [Display(Name="Email")]
        public string EmailAddress { get; set; }

        //public virtual List<Session> Sessions { get; set; }
    }
}
