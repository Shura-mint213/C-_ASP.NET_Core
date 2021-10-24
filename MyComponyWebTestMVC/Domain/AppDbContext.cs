using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyComponyWebTestMVC.Domain.Entities;

namespace MyComponyWebTestMVC.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {         
                Id = "eca1e1da-fe6c-4586-9960-0538925891fc",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {        
                Id = "4be75d51-6b99-471e-85d4-0ce46aaa449d",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {             
                RoleId = "eca1e1da-fe6c-4586-9960-0538925891fc",
                UserId = "4be75d51-6b99-471e-85d4-0ce46aaa449d"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {                  
                Id = new Guid("42fd9be9-1d4a-4664-b992-381bab8bdbec"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {                  
                Id = new Guid("7dc8a318-e84c-4e44-8643-8bcb44da48f8"),
                CodeWord = "PageServies",
                Title = "Наши услуги"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {                  
                Id = new Guid("35c2e431-2393-43d5-974a-d680716beb39"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }
    }
}
