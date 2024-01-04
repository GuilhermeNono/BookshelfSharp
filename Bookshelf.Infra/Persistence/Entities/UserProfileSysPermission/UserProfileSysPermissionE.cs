using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.SysPermission;
using Bookshelf.Infra.Persistence.Entities.UserProfile;

namespace Bookshelf.Infra.Persistence.Entities.UserProfileSysPermission;

[Table("UserProfileSysPermission")]
public class UserProfileSysPermissionE
{
    [Key]
    public long Id { get; set; }

    [ForeignKey("SysPermission")]
    public long SysPermissionId { get; set; }
    public SysPermissionE SysPermission { get; set; }
    
    [ForeignKey("UserProfile")]
    public long UserProfileId { get; set; }
    public UserProfileE UserProfile { get; set; }
}