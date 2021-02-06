using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBrowser.Repository
{
    class ShopContext : DbContext
    {
        public DbSet<ShopEntity> ShopEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-3BAAIFR\\SQLEXPRESS;Initial Catalog=ShopBase;User ID = sa; Password = Password123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShopEntity>().HasData(new ShopEntity() { Id = 1, Name = "eMobile", OpenTime = DateTime.Parse("08:00:00"), CloseTime = DateTime.Parse("22:00:00"), Description = "eMobile Shop" });
            modelBuilder.Entity<ShopEntity>().HasData(new ShopEntity() { Id = 2, Name = "Кандаловъ", OpenTime = DateTime.Parse("08:00:00"), CloseTime = DateTime.Parse("20:00:00"), Description = "Кандаловъ Shop" });
            modelBuilder.Entity<ShopEntity>().HasData(new ShopEntity() { Id = 3, Name = "MEX", OpenTime = DateTime.Parse("09:00:00"), CloseTime = DateTime.Parse("22:00:00"), Description = "MEX Shop" });
            modelBuilder.Entity<ShopEntity>().HasData(new ShopEntity() { Id = 4, Name = "патриот", OpenTime = DateTime.Parse("09:00:00"), CloseTime = DateTime.Parse("21:00:00"), Description = "патриот Shop" });
            modelBuilder.Entity<ShopEntity>().HasData(new ShopEntity() { Id = 5, Name = "Hot-Line", OpenTime = DateTime.Parse("09:00:00"), CloseTime = DateTime.Parse("22:00:00"), Description = "Hot-Line Shop" });
        }
    }
}
