namespace Propdalal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Project
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string SqureFitArea { get; set; }

        public string BathRoom { get; set; }

        public string BedRoom { get; set; }

        public string Balconi { get; set; }

        public string Kitchen { get; set; }

        public string Description { get; set; }

        public string Contact { get; set; }

        public string Address { get; set; }

        public int FloorLevel { get; set; }

        public string MainEntranceFacing { get; set; }

        public int PropertyTypeID { get; set; }

        public int RentSaleID { get; set; }

        public int LocationAreaID { get; set; }

        public bool SecurityCharge { get; set; }

        public string SecurityPrice { get; set; }

        public string SecurityDesc { get; set; }

        public string MaintenanceCharge { get; set; }

        public string MaintenancePrice { get; set; }

        public string Maintenance { get; set; }

        public bool PowerBackup { get; set; }

        public bool Lift { get; set; }

        public bool GusPipline { get; set; }

        public bool SwimmingPool { get; set; }

        public bool Gim { get; set; }

        public bool Ac { get; set; }

        public bool TV { get; set; }

        public bool Sofa { get; set; }

        public bool StoreRoom { get; set; }

        public bool ShowOnHomePage { get; set; }

        public bool ServentRoom { get; set; }

        public bool IsActive { get; set; }

        public int JDA { get; set; }

        public int RSPdetailID { get; set; }

        public virtual LocationArea LocationArea { get; set; }

        public virtual PropertyType PropertyType { get; set; }

        public virtual RentSale RentSale { get; set; }
    }
}
