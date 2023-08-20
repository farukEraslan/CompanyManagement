namespace CompanyManagement.Dtos.UserDto
{
    public class UserCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string? ImageURL { get; set; }
        public bool IsActıve { get; set; }
        public string Username = Guid.NewGuid().ToString();
        public string Email { get; set; }
        public string Password { get; set; }        
        public string PhoneNumber { get; set; }        
    }
}
