using CompanyManagement.Core.Entities.Interfaces;

namespace CompanyManagement.Core.Entities.Base;

public abstract class AuditableEntity : BaseEntity, ISoftDeletableEntity
{
    public string? DeletedBy { get; set; }
    public DateTime? DeletedDate { get; set; }
}
