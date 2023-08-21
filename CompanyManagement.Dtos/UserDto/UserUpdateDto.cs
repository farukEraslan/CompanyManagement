namespace CompanyManagement.Dtos.UserDto
{
    public class UserUpdateDto
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Gender? Gender { get; set; }
        public string? Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? ImageURL { get; set; }
        public string? Email { get; set; }
    }
}
