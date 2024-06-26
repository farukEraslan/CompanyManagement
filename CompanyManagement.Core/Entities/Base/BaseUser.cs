﻿using CompanyManagement.Core.Utilities.Helpers;

namespace CompanyManagement.Core.Entities.Base;

public abstract class BaseUser : AuditableEntity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string FullName => $"{FirstName} {LastName}";
    public string Email { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public bool Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? IdentificationNumber { get; set; }
    public string? Image { get; set; }
    public string Password { get; set; } = AuthenticationHelper.GenerateRandomPassword();
    public string? UserName { get; set; }
}
