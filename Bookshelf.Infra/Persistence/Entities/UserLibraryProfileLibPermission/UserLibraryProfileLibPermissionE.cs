using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.LibPermission;
using Bookshelf.Infra.Persistence.Entities.UserLibraryProfile;

namespace Bookshelf.Infra.Persistence.Entities.UserLibraryProfileLibPermission;

[Table("UserLibraryProfileLibPermission")]
public class UserLibraryProfileLibPermissionE
{
    [Key] public long Id { get; set; }
    
    [ForeignKey("LibPermission")]
    public long LibPermissionId { get; set; }
    public LibPermissionE LibPermission { get; set; }
    
    [ForeignKey("UserLibraryProfile")]
    public long UserLibraryProfileId { get; set; }
    public UserLibraryProfileE UserLibraryProfile { get; set; }
}