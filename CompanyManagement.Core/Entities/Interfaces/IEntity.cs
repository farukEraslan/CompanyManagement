﻿using CompanyManagement.Core.Enums;

namespace CompanyManagement.Core.Entities.Interfaces;

public interface IEntity
{
    Guid Id { get; set; }
    Status Status { get; set; }
}
