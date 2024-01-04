﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookshelf.Infra.Persistence.Entities.LibPermission;

[Table("LibPermission")]
public class LibPermissionE
{
    [Key] public long Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}