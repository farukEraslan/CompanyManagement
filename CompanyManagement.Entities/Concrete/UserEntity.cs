namespace CompanyManagement.Entities.Concrete
{
    public class UserEntity : IdentityUser<Guid>
    {
        public UserEntity()
        {
            
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string? ImageURL { get; set; }
        public bool IsActıve { get; set; }
    }
}
