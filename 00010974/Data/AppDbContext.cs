
using _00010974.Models;
using Microsoft.EntityFrameworkCore;

namespace _00010974.Data

{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books_Publishers>().HasKey(bp => new
            {
                bp.BooksId,
                bp.PublishersId
            });

            modelBuilder.Entity<Books_Publishers>().HasOne(b => b.Books).WithMany(bp => bp.Books_Publishers).HasForeignKey(b => b.BooksId);
            modelBuilder.Entity<Books_Publishers>().HasOne(b => b.Publishers).WithMany(bp => bp.Books_Publishers).HasForeignKey(b => b.PublishersId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Publishers> Publishers { get; set; }
        public DbSet<Books_Publishers> Books_Publishers { get; set; }
        public DbSet<Authors> Authors { get; set; }
       
    }
}
