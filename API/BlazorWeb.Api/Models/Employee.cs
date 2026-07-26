using BlazorWeb.Shared.Domain.Enums;

namespace BlazorWeb.Api.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public string? JobTitle { get; set; }
        public string? ShortBio { get; set; }
    }
}
