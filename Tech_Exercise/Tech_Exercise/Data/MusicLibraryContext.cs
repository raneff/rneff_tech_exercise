using System;
using static Tech_Exercise.Models.MusicLibraryModel;
using Microsoft.EntityFrameworkCore;
namespace Tech_Exercise.Data
{
    public class MusicLibraryContext : DbContext
    {
        public DbSet<Song> Song { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=ec2-18-218-148-230.us-east-2.compute.amazonaws.com;database=musiclibrary;user=rneff;password=Joshbell22@");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Song>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Piece).IsRequired();
                entity.Property(e => e.Composer).IsRequired();
            });

           
        }
    }
}
