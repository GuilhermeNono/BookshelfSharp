using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.Base;
using Bookshelf.Infra.Persistence.Entities.Library;
using Bookshelf.Infra.Persistence.Entities.UserAccount;
using Bookshelf.Infra.Persistence.Entities.UserLibraryProfile;

namespace Bookshelf.Infra.Persistence.Entities.UserLibrary;

[Table("UserLibrary")]
public class UserLibraryE: BaseEntity
{
    [Key] 
    public long Id { get; set; }

    public string RmRa { get; set; } = string.Empty;
    public string ProfilePicture { get; set; } = string.Empty;
    public bool Active { get; set; }

    [ForeignKey("Library")]
    public long LibraryId { get; set; }
    public LibraryE Library { get; set; }

    [ForeignKey("UserAccount")]
    public long UserAccountId { get; set; }
    public UserAccountE UserAccount { get; set; }

    [ForeignKey("UserLibraryProfile")]
    public long UserLibraryProfileId { get; set; }
    public UserLibraryProfileE UserLibraryProfile { get; set; }
}