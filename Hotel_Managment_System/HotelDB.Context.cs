﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Managment_System
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelManagementSystemEntities : DbContext//, IHotelManagementSystemEntities
    {
        public HotelManagementSystemEntities()
            : base("name=HotelManagementSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<DataStorage> DataStorages { get; set; }
    }

    internal interface IHotelManagementSystemEntities
    {
          DbSet<Client> Clients { get; set; }
          DbSet<Reservation> Reservations { get; set; }
          DbSet<Room> Rooms { get; set; }
          DbSet<sysdiagram> sysdiagrams { get; set; }
          DbSet<User> Users { get; set; }
          DbSet<DataStorage> DataStorages { get; set; }
    }
}
