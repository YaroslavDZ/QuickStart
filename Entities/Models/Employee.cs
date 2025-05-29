using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; } // Changed from DateOf

        public string? Position { get; set; }

        public int? Salary { get; set; } // Added Salary property
    }
}
