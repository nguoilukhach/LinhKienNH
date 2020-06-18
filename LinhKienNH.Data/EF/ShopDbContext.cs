using LinhKienNH.Data.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.EF
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext( DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
 