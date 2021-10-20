using Events.Data.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Data.Context
{
    public class EventsContext : IdentityDbContext
    {
        public EventsContext(DbContextOptions options) : base(options)
        {

        }

        #region DbSets

        public virtual DbSet<Event> Events { get; set; }

        #endregion DbSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Event>()
              .HasData(
               new Event { Id = 1, Name = "ჯაზზ საღამო მუშტაიდის ბაღში", Date = new DateTime(2021, 10, 24), CreateDate = DateTime.Now, Image = "https://georgiantravelguide.com/storage/files/img-20200725-153140.jpg" });
        }
    }
}
