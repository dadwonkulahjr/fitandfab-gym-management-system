using FitAndFabulous.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitAndFabulous.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Position> Positions { get; set; }

        public DbSet<Suffix> Suffixes { get; set; }

        public DbSet<Gym> Gyms { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Membership> Memberships { get; set; }

        public DbSet<Package> Packages { get; set; }

        public DbSet<AccessDays> AccessDays { get; set; }

        public DbSet<Day> Days { get; set; }

        public DbSet<TrainingClass> TrainingClasses { get; set; }

        public DbSet<PersonTrainingClass> PersonTrainingClasses { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PersonTrainingClass>().HasKey(ptc => new { ptc.PersonId, ptc.TrainingClassId });

        }
    }
}
