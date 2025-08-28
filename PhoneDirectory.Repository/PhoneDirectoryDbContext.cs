using Microsoft.EntityFrameworkCore;
using PhoneDirectory.Entity;

namespace PhoneDirectory.Repository
{
    public class PhoneDirectoryDbContext : DbContext
    {
        public PhoneDirectoryDbContext(DbContextOptions<PhoneDirectoryDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactGroup> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasOne(c => c.Group).WithMany(g => g.Contacts).HasForeignKey(c => c.GroupId).IsRequired(false).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Contact>().OwnsMany(c => c.Addresses); 
            modelBuilder.Entity<Contact>().OwnsMany(c => c.PhoneNumbers); 
            modelBuilder.Entity<Contact>().OwnsMany(c => c.Emails); 
            modelBuilder.Entity<Contact>().OwnsMany(c => c.RelatedPeople); 
            modelBuilder.Entity<Contact>().OwnsMany(c => c.SocialProfiles); 
        }
    }
}
