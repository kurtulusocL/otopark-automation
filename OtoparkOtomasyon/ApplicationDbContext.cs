using OtoparkOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyon
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarPark> CarParks { get; set; }
        public DbSet<CarParkInfo> CarParkInfoes { get; set; }
        public DbSet<Serial> Serials { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
