namespace CompanyManagement.Dtos.Account
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Email kısmı boş bırakılamaz.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre kısmı boş bırakılamaz.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
