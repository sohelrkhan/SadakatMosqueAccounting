namespace SadaqaAccounting.Model.Models
{
    public class Employee : BaseEntity
    {
        public string EmployeeCode { get; set; }

        public string FullName { get; set; }

        public string Designation { get; set; }

        public decimal Salary { get; set; }

        public string Mobile { get; set; }
    }
}
