using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopCarMVC.Data.Models;

namespace ShopCarMVC.Data
{
    public class AppDBContent : DbContext 
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { }
        
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDerail { get; set; }
        

    }
}
