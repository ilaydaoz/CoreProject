﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pizzapan.EntityLayer.Concrete;

namespace Pizzapan.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext <AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AKOHCIC;initial catalog=CasgemDbPizzaPan;integrated security=true");
        }
       public DbSet<Category> Categories   { get; set; }
       public DbSet<Contact> Contacts { get; set; }
       public DbSet<Product> Products { get; set; }
       public DbSet<Testimoial> Testimoials { get; set; }
       public DbSet<Discount> Discounts { get; set; }
       public DbSet<ProductImage> ProductImages { get; set; }
       public DbSet<OurTeam> OurTeams { get; set; }
    }
}
