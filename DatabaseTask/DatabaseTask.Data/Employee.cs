using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Data
{
    public class Company
    {
        public int Id { get; set; }
        public string RegistryType { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactEmail { get; set; }
        public string Comment { get; set; }

        public ICollection<EmploymentCondition> EmploymentConditions { get; set; }
    }

    public class AdministrativeUnitType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCommissioning { get; set; }
        public DateTime? DateOfLiquidation { get; set; }
        public string Comment { get; set; }

        public ICollection<AdministrativeUnit> AdministrativeUnits { get; set; }
    }

    public class AdministrativeUnit
    {
        public int Id { get; set; }
        public int AdministrativeUnitTypeId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string ContactEmail { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LiquidationDate { get; set; }
        public string Comment { get; set; }

        [ForeignKey("AdministrativeUnitTypeId")]
        public AdministrativeUnitType AdministrativeUnitType { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<EmploymentCondition> EmploymentConditions { get; set; }
        public ICollection<AccessPermissions> AccessPermissions { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string PersonalCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ContactAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactEmail { get; set; }
        public int? ChildrenId { get; set; }
        public int? EmploymentConditionId { get; set; }
        public int? VacationId { get; set; }
        public int? SickLogId { get; set; }
        public int? HealthChecksId { get; set; }
        public int? AnonymousReportId { get; set; }
        public int? RequestsReportId { get; set; }
        public int AdministrativeUnitId { get; set; }

        [ForeignKey("AdministrativeUnitId")]
        public AdministrativeUnit AdministrativeUnit { get; set; }

        public ICollection<EmploymentCondition> EmploymentConditions { get; set; }
        public ICollection<JobType> JobTypes { get; set; }
        public ICollection<Children> Children { get; set; }
        public ICollection<Vacations> Vacations { get; set; }
        public ICollection<SickLog> SickLogs { get; set; }
        public ICollection<HealthChecks> HealthChecks { get; set; }
        public ICollection<AnonymousReport> AnonymousReports { get; set; }
        public ICollection<RequestsReport> RequestsReports { get; set; }
        public ICollection<AccessPermissions> AccessPermissions { get; set; }
    }

    public class EmploymentCondition
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public int AdministrativeUnitId { get; set; }
        public int JobTypeId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LiquidationDate { get; set; }
        public string Comment { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        [ForeignKey("AdministrativeUnitId")]
        public AdministrativeUnit AdministrativeUnit { get; set; }

        public ICollection<JobType> JobTypes { get; set; }
    }

    public class JobType
    {
        public int Id { get; set; }
        public int EmploymentConditionId { get; set; }
        public int EmployeeId { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LiquidationDate { get; set; }
        public string Comment { get; set; }

        [ForeignKey("EmploymentConditionId")]
        public EmploymentCondition EmploymentCondition { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }

    public class Children
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PersonalCode { get; set; }
        public string Comment { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }

    public class Vacations
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Days { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }

    public class SickLog
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Days { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public ICollection<HealthChecks> HealthChecks { get; set; }
    }

    public class HealthChecks
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Days { get; set; }
        public int HealthStatus { get; set; }
        public int SickLogId { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ForeignKey("SickLogId")]
        public SickLog SickLog { get; set; }
    }

    public class AnonymousReport
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }

    public class RequestsReport
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string ContactEmail { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }

    public class AccessPermissions
    {
        public int Id { get; set; }
        public int AdministrativeUnitId { get; set; }
        public int EmployeeId { get; set; }
        public string RentalStatus { get; set; }
        public string DoorCard { get; set; }
        public string Comment { get; set; }
        public string PermissionName { get; set; }

        [ForeignKey("AdministrativeUnitId")]
        public AdministrativeUnit AdministrativeUnit { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public ICollection<RentalItems> RentalItems { get; set; }
        public ICollection<RentalList> RentalLists { get; set; }
        public ICollection<DoorCard> DoorCards { get; set; }
    }

    public class RentalItems
    {
        public int Id { get; set; }
        public int AccessPermissionsId { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public string ItemStatus { get; set; }
        public DateTime PurchasedDate { get; set; }
        public DateTime? LiquidationDate { get; set; }
        public string Comment { get; set; }

        [ForeignKey("AccessPermissionsId")]
        public AccessPermissions AccessPermissions { get; set; }

        public ICollection<RentalList> RentalLists { get; set; }
    }

    public class RentalList
    {
        public int Id { get; set; }
        public int AccessPermissionsId { get; set; }
        public int RentalItemsId { get; set; }
        public string RentalStatus { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string ItemStatus { get; set; }
        public string Comment { get; set; }

        [ForeignKey("AccessPermissionsId")]
        public AccessPermissions AccessPermissions { get; set; }

        [ForeignKey("RentalItemsId")]
        public RentalItems RentalItems { get; set; }
    }

    public class DoorCard
    {
        public int Id { get; set; }
        public int AccessPermissionsId { get; set; }
        public string CardNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public AccessPermissions AccessPermissions { get; set; }
    }
}
