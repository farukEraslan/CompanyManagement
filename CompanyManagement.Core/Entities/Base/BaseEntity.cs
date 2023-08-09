using CompanyManagement.Core.Entities.Interfaces;

namespace CompanyManagement.Core.Entities.Base;

public abstract class BaseEntity : IEntity, ICreateableEntity, IUpdateableEntity
{
    public Guid Id { get; set; }
    public Status Status { get; set; }
    public string CreatedBy { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
    public string ModifiedBy { get; set; } = null!;
    public DateTime ModifiedDate { get; set; }
}
