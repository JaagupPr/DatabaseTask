﻿// <auto-generated />
using System;
using DatabaseTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DatabaseTask.Data.AccessPermissions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdministrativeUnitId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoorCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RentalStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdministrativeUnitId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("AccessPermissions");
                });

            modelBuilder.Entity("DatabaseTask.Data.AdministrativeUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdministrativeUnitTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LiquidationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdministrativeUnitTypeId");

                    b.ToTable("AdministrativeUnits");
                });

            modelBuilder.Entity("DatabaseTask.Data.AdministrativeUnitType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCommissioning")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfLiquidation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdministrativeUnitTypes");
                });

            modelBuilder.Entity("DatabaseTask.Data.AnonymousReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("AnonymousReports");
                });

            modelBuilder.Entity("DatabaseTask.Data.Children", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("DatabaseTask.Data.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DatabaseTask.Data.DoorCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessPermissionsId")
                        .HasColumnType("int");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccessPermissionsId");

                    b.ToTable("DoorCards");
                });

            modelBuilder.Entity("DatabaseTask.Data.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdministrativeUnitId")
                        .HasColumnType("int");

                    b.Property<int?>("AnonymousReportId")
                        .HasColumnType("int");

                    b.Property<int?>("ChildrenId")
                        .HasColumnType("int");

                    b.Property<string>("ContactAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmploymentConditionId")
                        .HasColumnType("int");

                    b.Property<int?>("HealthChecksId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RequestsReportId")
                        .HasColumnType("int");

                    b.Property<int?>("SickLogId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VacationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdministrativeUnitId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DatabaseTask.Data.EmploymentCondition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdministrativeUnitId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("JobTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LiquidationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AdministrativeUnitId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmploymentConditions");
                });

            modelBuilder.Entity("DatabaseTask.Data.HealthChecks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HealthStatus")
                        .HasColumnType("int");

                    b.Property<int>("SickLogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("SickLogId");

                    b.ToTable("HealthChecks");
                });

            modelBuilder.Entity("DatabaseTask.Data.JobType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EmploymentConditionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LiquidationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EmploymentConditionId");

                    b.ToTable("JobTypes");
                });

            modelBuilder.Entity("DatabaseTask.Data.RentalItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessPermissionsId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LiquidationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PurchasedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccessPermissionsId");

                    b.ToTable("RentalItems");
                });

            modelBuilder.Entity("DatabaseTask.Data.RentalList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessPermissionsId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ItemStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RentalDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RentalItemsId")
                        .HasColumnType("int");

                    b.Property<string>("RentalStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccessPermissionsId");

                    b.HasIndex("RentalItemsId");

                    b.ToTable("RentalLists");
                });

            modelBuilder.Entity("DatabaseTask.Data.RequestsReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("RequestsReports");
                });

            modelBuilder.Entity("DatabaseTask.Data.SickLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("SickLogs");
                });

            modelBuilder.Entity("DatabaseTask.Data.Vacations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("DatabaseTask.Data.AccessPermissions", b =>
                {
                    b.HasOne("DatabaseTask.Data.AdministrativeUnit", "AdministrativeUnit")
                        .WithMany("AccessPermissions")
                        .HasForeignKey("AdministrativeUnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Data.Employee", "Employee")
                        .WithMany("AccessPermissions")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AdministrativeUnit");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Data.AdministrativeUnit", b =>
                {
                    b.HasOne("DatabaseTask.Data.AdministrativeUnitType", "AdministrativeUnitType")
                        .WithMany("AdministrativeUnits")
                        .HasForeignKey("AdministrativeUnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdministrativeUnitType");
                });

            modelBuilder.Entity("DatabaseTask.Data.AnonymousReport", b =>
                {
                    b.HasOne("DatabaseTask.Data.Employee", "Employee")
                        .WithMany("AnonymousReports")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Data.Children", b =>
                {
                    b.HasOne("DatabaseTask.Data.Employee", "Employee")
                        .WithMany("Children")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Data.DoorCard", b =>
                {
                    b.HasOne("DatabaseTask.Data.AccessPermissions", "AccessPermissions")
                        .WithMany("DoorCards")
                        .HasForeignKey("AccessPermissionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessPermissions");
                });

            modelBuilder.Entity("DatabaseTask.Data.Employee", b =>
                {
                    b.HasOne("DatabaseTask.Data.AdministrativeUnit", "AdministrativeUnit")
                        .WithMany("Employees")
                        .HasForeignKey("AdministrativeUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdministrativeUnit");
                });

            modelBuilder.Entity("DatabaseTask.Data.EmploymentCondition", b =>
                {
                    b.HasOne("DatabaseTask.Data.AdministrativeUnit", "AdministrativeUnit")
                        .WithMany("EmploymentConditions")
                        .HasForeignKey("AdministrativeUnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Data.Company", "Company")
                        .WithMany("EmploymentConditions")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Data.Employee", "Employee")
                        .WithMany("EmploymentConditions")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AdministrativeUnit");

                    b.Navigation("Company");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Data.HealthChecks", b =>
                {
                    b.HasOne("DatabaseTask.Data.Employee", "Employee")
                        .WithMany("HealthChecks")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Data.SickLog", "SickLog")
                        .WithMany("HealthChecks")
                        .HasForeignKey("SickLogId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("SickLog");
                });

            modelBuilder.Entity("DatabaseTask.Data.JobType", b =>
                {
                    b.HasOne("DatabaseTask.Data.Employee", "Employee")
                        .WithMany("JobTypes")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Data.EmploymentCondition", "EmploymentCondition")
                        .WithMany("JobTypes")
                        .HasForeignKey("EmploymentConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("EmploymentCondition");
                });

            modelBuilder.Entity("DatabaseTask.Data.RentalItems", b =>
                {
                    b.HasOne("DatabaseTask.Data.AccessPermissions", "AccessPermissions")
                        .WithMany("RentalItems")
                        .HasForeignKey("AccessPermissionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessPermissions");
                });

            modelBuilder.Entity("DatabaseTask.Data.RentalList", b =>
                {
                    b.HasOne("DatabaseTask.Data.AccessPermissions", "AccessPermissions")
                        .WithMany("RentalLists")
                        .HasForeignKey("AccessPermissionsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Data.RentalItems", "RentalItems")
                        .WithMany("RentalLists")
                        .HasForeignKey("RentalItemsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AccessPermissions");

                    b.Navigation("RentalItems");
                });

            modelBuilder.Entity("DatabaseTask.Data.RequestsReport", b =>
                {
                    b.HasOne("DatabaseTask.Data.Employee", "Employee")
                        .WithMany("RequestsReports")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Data.SickLog", b =>
                {
                    b.HasOne("DatabaseTask.Data.Employee", "Employee")
                        .WithMany("SickLogs")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Data.Vacations", b =>
                {
                    b.HasOne("DatabaseTask.Data.Employee", "Employee")
                        .WithMany("Vacations")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Data.AccessPermissions", b =>
                {
                    b.Navigation("DoorCards");

                    b.Navigation("RentalItems");

                    b.Navigation("RentalLists");
                });

            modelBuilder.Entity("DatabaseTask.Data.AdministrativeUnit", b =>
                {
                    b.Navigation("AccessPermissions");

                    b.Navigation("Employees");

                    b.Navigation("EmploymentConditions");
                });

            modelBuilder.Entity("DatabaseTask.Data.AdministrativeUnitType", b =>
                {
                    b.Navigation("AdministrativeUnits");
                });

            modelBuilder.Entity("DatabaseTask.Data.Company", b =>
                {
                    b.Navigation("EmploymentConditions");
                });

            modelBuilder.Entity("DatabaseTask.Data.Employee", b =>
                {
                    b.Navigation("AccessPermissions");

                    b.Navigation("AnonymousReports");

                    b.Navigation("Children");

                    b.Navigation("EmploymentConditions");

                    b.Navigation("HealthChecks");

                    b.Navigation("JobTypes");

                    b.Navigation("RequestsReports");

                    b.Navigation("SickLogs");

                    b.Navigation("Vacations");
                });

            modelBuilder.Entity("DatabaseTask.Data.EmploymentCondition", b =>
                {
                    b.Navigation("JobTypes");
                });

            modelBuilder.Entity("DatabaseTask.Data.RentalItems", b =>
                {
                    b.Navigation("RentalLists");
                });

            modelBuilder.Entity("DatabaseTask.Data.SickLog", b =>
                {
                    b.Navigation("HealthChecks");
                });
#pragma warning restore 612, 618
        }
    }
}
