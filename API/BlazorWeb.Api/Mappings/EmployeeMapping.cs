using BlazorWeb.Shared.Domain.Responses;
using BlazorWeb.Api.Models;

namespace BlazorWeb.Api.Mappings
{
    public static class EmployeeMapping
    {
        public static EmployeeResponse ToResponse(this Employee employee) => new()
        {
            EmployeeId = employee.EmployeeId,
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            Email = employee.Email,
            PhoneNumber = employee.PhoneNumber,
            MaritalStatus = employee.MaritalStatus,
            Gender = employee.Gender,
            Department = employee.Department,
            JobTitle = employee.JobTitle,
            ShortBio = employee.ShortBio
        };
        private static Employee ToEntity(EmployeeResponse d) => new()
        {
            EmployeeId = d.EmployeeId,
            FirstName = d.FirstName,
            LastName = d.LastName,
            Email = d.Email,
            PhoneNumber = d.PhoneNumber,
            MaritalStatus = d.MaritalStatus,
            Gender = d.Gender,
            Department = d.Department,
            JobTitle = d.JobTitle,
            ShortBio = d.ShortBio
        };
    }
}
