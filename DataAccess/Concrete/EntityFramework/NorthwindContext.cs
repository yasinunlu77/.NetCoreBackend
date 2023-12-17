using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile projedeki class(Entity)ları bağlar. 
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; } //Bende Product class'ını veri tablosunda Products tablosuna bağla.
        public DbSet<Category> Categories { get; set; } //Bende Category class'ını veri tablosunda Categories tablosuna bağla.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=Northwind;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;" +
                "Encrypt=False;" +
                "Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;" +
                "Multi Subnet Failover=False");
        }

    }
}
