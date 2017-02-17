namespace Propdalal.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HousingModel : DbContext
    {
        public HousingModel()
            : base("name=Housing")
        {
        }

        public virtual DbSet<LocationArea> LocationAreas { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<RentSale> RentSales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
