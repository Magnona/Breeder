using Microsoft.EntityFrameworkCore;
using DatabaseAccess.Entities;

namespace DatabaseAccess.Data
{
    public class BreederContext : DbContext
    {
        #region c-tor
        public BreederContext(DbContextOptions<BreederContext> options) : base(options)
        {
        }
        #endregion

        #region Properties
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Video> Videos { get; set; }

        #endregion

        #region override
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>().ToTable("Pet");
            modelBuilder.Entity<Breed>().ToTable("Breed");
            modelBuilder.Entity<Color>().ToTable("Color");
            modelBuilder.Entity<Photo>().ToTable("Photo");
            modelBuilder.Entity<Status>().ToTable("Status");
            modelBuilder.Entity<Video>().ToTable("Video");

        }
        #endregion
    }
}