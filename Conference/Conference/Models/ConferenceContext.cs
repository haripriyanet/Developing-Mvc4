using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Models
{

    public class ConferenceContext : DbContext
    {
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Speaker> Speakers { get; set; }

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
