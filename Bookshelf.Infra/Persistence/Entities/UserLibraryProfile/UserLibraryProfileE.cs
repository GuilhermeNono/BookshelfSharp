using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Azure.Core;

namespace Bookshelf.Infra.Persistence.Entities.UserLibraryProfile;

[Table("UserLibraryProfile")]
public class UserLibraryProfileE
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
}