namespace PawsHome.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NewModel : DbContext
    {
        public NewModel()
            : base("name=NewModel")
        {
        }

        public virtual DbSet<Dog> Dogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dog>()
                .Property(e => e.breed)
                .IsUnicode(false);

            modelBuilder.Entity<Dog>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<Dog>()
                .Property(e => e.weight)
                .IsUnicode(false);

            modelBuilder.Entity<Dog>()
                .Property(e => e.height)
                .IsUnicode(false);

            modelBuilder.Entity<Dog>()
                .Property(e => e.expectancy)
                .IsUnicode(false);

            modelBuilder.Entity<Dog>()
                .Property(e => e.origin)
                .IsUnicode(false);

            modelBuilder.Entity<Dog>()
                .Property(e => e.size)
                .IsUnicode(false);

            modelBuilder.Entity<Dog>()
                .Property(e => e.temperament)
                .IsUnicode(false);
        }
    }
}
