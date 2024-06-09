using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatabaseTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<AdministrativeUnitType> AdministrativeUnitTypes { get; set; }
        public DbSet<AdministrativeUnit> AdministrativeUnits { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmploymentCondition> EmploymentConditions { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Children> Children { get; set; }
        public DbSet<Vacations> Vacations { get; set; }
        public DbSet<SickLog> SickLogs { get; set; }
        public DbSet<HealthChecks> HealthChecks { get; set; }
        public DbSet<AnonymousReport> AnonymousReports { get; set; }
        public DbSet<RequestsReport> RequestsReports { get; set; }
        public DbSet<AccessPermissions> AccessPermissions { get; set; }
        public DbSet<RentalItems> RentalItems { get; set; }
        public DbSet<RentalList> RentalLists { get; set; }
        public DbSet<DoorCard> DoorCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessPermissions>()
                .HasOne(ap => ap.AdministrativeUnit)
                .WithMany(au => au.AccessPermissions)
                .HasForeignKey(ap => ap.AdministrativeUnitId)
                .OnDelete(DeleteBehavior.Restrict);  // Change to Restrict or NoAction

            modelBuilder.Entity<AccessPermissions>()
                .HasOne(ap => ap.Employee)
                .WithMany(e => e.AccessPermissions)
                .HasForeignKey(ap => ap.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);  // Change to Restrict or NoAction

            modelBuilder.Entity<EmploymentCondition>()
       .HasOne(ec => ec.AdministrativeUnit)
       .WithMany(au => au.EmploymentConditions)
       .HasForeignKey(ec => ec.AdministrativeUnitId)
       .OnDelete(DeleteBehavior.Restrict);  // Change to Restrict or NoAction

            modelBuilder.Entity<EmploymentCondition>()
                .HasOne(ec => ec.Company)
                .WithMany(c => c.EmploymentConditions)
                .HasForeignKey(ec => ec.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);  // Change to Restrict or NoAction

            modelBuilder.Entity<EmploymentCondition>()
                .HasOne(ec => ec.Employee)
                .WithMany(e => e.EmploymentConditions)
                .HasForeignKey(ec => ec.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);  // Change to Restrict or NoAction

            modelBuilder.Entity<HealthChecks>()
        .HasOne(hc => hc.Employee)
        .WithMany(e => e.HealthChecks)
        .HasForeignKey(hc => hc.EmployeeId)
        .OnDelete(DeleteBehavior.Restrict);  // Change to Restrict or NoAction

            modelBuilder.Entity<HealthChecks>()
                .HasOne(hc => hc.SickLog)
                .WithMany(sl => sl.HealthChecks)
                .HasForeignKey(hc => hc.SickLogId)
                .OnDelete(DeleteBehavior.Restrict);  // Change to Restrict or NoAction

            modelBuilder.Entity<RentalList>()
        .HasOne(rl => rl.AccessPermissions)
        .WithMany(ap => ap.RentalLists)
        .HasForeignKey(rl => rl.AccessPermissionsId)
        .OnDelete(DeleteBehavior.Restrict);  // Change to Restrict or NoAction

            modelBuilder.Entity<RentalList>()
                .HasOne(rl => rl.RentalItems)
                .WithMany(ri => ri.RentalLists)
                .HasForeignKey(rl => rl.RentalItemsId)
                .OnDelete(DeleteBehavior.Restrict);  // Change to Restrict or NoAction
          
            modelBuilder.Entity<DoorCard>()
               .HasOne(dc => dc.AccessPermissions)
               .WithMany(ap => ap.DoorCards)
               .HasForeignKey(dc => dc.AccessPermissionsId)
               .OnDelete(DeleteBehavior.Cascade);  // Adjust as necessary

            // Add other configurations as necessary
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DataBaseTasks;Trusted_Connection=true;MultipleActiveResultSets=true");
        }
    }
}
