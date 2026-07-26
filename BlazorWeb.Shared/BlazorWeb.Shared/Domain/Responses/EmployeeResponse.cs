using BlazorWeb.Shared.Domain.Enums;

namespace BlazorWeb.Shared.Domain.Responses
{
    public class EmployeeResponse
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
    }
}
