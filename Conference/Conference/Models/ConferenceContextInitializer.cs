using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Models
{
    public class ConferenceContextInitializer : DropCreateDatabaseAlways<ConferenceContext>
    {
        protected override void Seed(ConferenceContext context)
        {
            context.Sessions.Add
                (
                    new Session
                    {
                        Title = "I Want Spaghettit",
                        Abstract = "THe life and times of a spaghetti lover",
                        Speaker = context.Speakers.Add
                        (
                            new Speaker
                            {
                                Name = "Jon Galloway",
                                EmailAddress = "jon@nowwhere.com"
                            }
                        )
                    }
                );
            //context.Speakers.Add
            //    (

            //        new Speaker()
            //        {
            //             Name = "Jon Galloway",
            //             EmailAddress = "Jon@nowhere.com"
            //        }
            //    );

            context.SaveChanges();
        }
    }

}
