namespace CompanyManagement.Dtos.UserDto
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string? ImageURL { get; set; }
        public bool IsActıve { get; set; }
        public string PersonelMail { get; set; }
    }
}
