using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public int PositionId { get; set; }
        public Position? Position { get; set; }
        public string IPaddress { get; set; } = string.Empty;
        public string? IPcountryCode { get; set; }
    }
}
