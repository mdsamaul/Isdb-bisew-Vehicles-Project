using Microsoft.EntityFrameworkCore;
using System;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class VichecleDbContext:DbContext
    {
        public VichecleDbContext(DbContextOptions<VichecleDbContext> options) : base(options) { }

        // DbSet Properties for Tables
        public DbSet<Vehicle>? Vehicles { get; set; }
        public DbSet<VehicleType>? VehicleTypes { get; set; }
        public DbSet<RideBook>? RideBooks { get; set; }
        public DbSet<DriverVehicle>? DriverVehicles { get; set; }
        public DbSet<Driver>? Drivers { get; set; }
        public DbSet<RideTrack>? RideTracks { get; set; }
        public DbSet<FareDetail>? FareDetails { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Invoice>? Invoices { get; set; }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<Bank>? Banks { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Chat>? Chats { get; set; }

    }
}
