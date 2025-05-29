namespace Shared.DataTransferObjects.Employee
{
    public record EmployeeDto
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Position { get; set; }
        public int? Salary { get; set; }
    }
}
