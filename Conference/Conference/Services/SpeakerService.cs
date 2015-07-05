using Conference.Controllers;
using Conference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Conference.Services
{
    
    class SpeakerService
    {

        public static List<Speaker> DisplayAllSpeakers()
        {
            using (var ctx = new ConferenceContext())
            {
                return ctx.Speakers.ToList();
            }
        }

        public static Speaker GetSpeaker(int? id)
        {
            using (var ctx = new ConferenceContext())
            {
                return ctx.Speakers.Find(id);
            }
        }

        public static bool Create(Speaker speaker, ModelStateDictionary msd)
        {
            if (msd.IsValid)
            {
                using (var ctx = new ConferenceContext())
                {
                    ctx.Speakers.Add(speaker);
                    ctx.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public static bool Edit(Speaker speaker, ModelStateDictionary msd)
        {
            if (msd.IsValid)
            {
                using (var ctx = new ConferenceContext())
                {
                    ctx.Entry(speaker).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public static void DeleteSpeaker(int id)
        {
            using (var ctx = new ConferenceContext())
            {
                var speaker = ctx.Speakers.Find(id);
                ctx.Speakers.Remove(speaker);
                ctx.SaveChanges();
            }
        }
        
    }

}
