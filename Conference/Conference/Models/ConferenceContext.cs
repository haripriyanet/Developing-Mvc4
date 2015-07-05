using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class ConferenceContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ConferenceContext() : base("name=ConferenceContext")
        {
        }

        public System.Data.Entity.DbSet<Conference.Models.Speaker> Speakers { get; set; }
        public System.Data.Entity.DbSet<Conference.Models.Session> Sessions { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Session>().HasKey(t => t.SessionId);
            modelBuilder.Entity<Speaker>().HasKey(t => t.SpeakerId);
            modelBuilder.Entity<Session>().Property(t => t.Title).IsRequired();
            modelBuilder.Entity<Session>().Property(t => t.Abstract).IsRequired();
            modelBuilder.Entity<Session>().Property(t => t.Abstract)
                .HasColumnType("MultilineText");
            modelBuilder.Entity<Speaker>().Property(t => t.EmailAddress)
                .HasColumnType("EmailAddress");
        }
    }
}
