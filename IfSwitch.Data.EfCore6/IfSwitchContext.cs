using IfSwitch.Domain;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Security.Principal;
using System;

namespace IfSwitch.DataLayer.EfCore6
{
    public class IfSwitchContext : DbContext
    {
        public DbSet<Goods> TheGoods { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyGoods> TheCompanyGoods { get; set; }
        public DbSet<Price> Prices { get; set; }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                //"Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = IfSwitchDatabase"
                "Data Source = (localdb)\\v11.0; Initial Catalog = IfSwitchDatabase"
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var goodsList = new Goods[]
            {
                new Goods{GoodsId = 1, Name = "2 Tacos"},
                new Goods{GoodsId = 2, Name = "Mini Churros", QuantityPerUnit = 5},
                new Goods{GoodsId = 3, Name = "Chicken Nuggets", QuantityPerUnit = 10},
                new Goods{GoodsId = 4, Name = "Water", VolumeByDescription = "Medium Cup"},
                new Goods{GoodsId = 5, Name = "Fries", VolumeByDescription = "Value Size"},
                new Goods{GoodsId = 6, Name = "Kleenex", QuantityPerUnit = 4},
                new Goods{GoodsId = 7, Name = "Pepperoni", Brand = "Hormel"}, //size and brand
                new Goods{GoodsId = 8, Name = "5 Hour Extra Strength Berry", QuantityPerUnit = 1},
                new Goods{GoodsId = 9, Name = "5 Hour Extra Strength Berry", QuantityPerUnit = 6},
                new Goods{GoodsId = 10, Name = "5 Hour Extra Strength Berry", QuantityPerUnit = 10},
                new Goods{GoodsId = 11, Name = "5 Hour Extra Strength Berry", QuantityPerUnit = 15},

            };

            modelBuilder.Entity<Goods>().HasData(goodsList);

            var companyList = new Company[]
            {
                new Company{CompanyId = 1, Name = "Jack in the box"},
                new Company{CompanyId = 2, Name = "Walmart", Website = "www.walmart.com"},
                new Company{CompanyId = 3, Name = "Big Lots"},

            };

            modelBuilder.Entity<Company>().HasData(companyList);

            var priceList = new Price[]
            {
                new Price{PriceId = 1, Name = "Jack in the box"},
                new Price{PriceId = 2, Name = "Walmart", Website = "www.walmart.com"},
                new Price{PriceId = 3, Name = "Big Lots"},

            };

            modelBuilder.Entity<Company>().HasData(companyList);

        }
    }
}