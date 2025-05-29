namespace Shared.DataTransferObjects.Employee
{
    public abstract record EmployeeForManipulationDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Position { get; set; }
        public int? Salary { get; set; }
    }
}
