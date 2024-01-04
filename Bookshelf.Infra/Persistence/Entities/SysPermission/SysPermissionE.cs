using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookshelf.Infra.Persistence.Entities.SysPermission;

[Table("SysPermission")]
public class SysPermissionE
{
    [Key]
    public long Id { get; set; }

    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}