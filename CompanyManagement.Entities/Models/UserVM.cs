
using CompanyManagement.Entities.Enum;

namespace CompanyManagement.WebUI.Areas.User.Models
{
    public class UserVM
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string LastName { get; set; }
        public string? SecondLastName { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthLocation { get; set; }
        public string? ImageURL { get; set; }
        public bool? IsActıve { get; set; }
        public DateTime JobEnterDate { get; set; }
        public DateTime? JobExitDate { get; set; }
        public string Job { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int? TotalLeaveDay { get; set; }
        public string PersonelMail { get; set; }
        public string? ErrorMessage { get; set; }
        public Roles Role { get; set; }
    }
}
