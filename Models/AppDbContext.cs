using System;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Seed();//C# Extension: Sınıfın bütün özelliklerini kullanarak yeni method ekledik
            //Yukardaki satır yerine Seed metodunun bodysindekiler burada idi

        }


        public DbSet<Book> Books { get; set; }

    }
}
