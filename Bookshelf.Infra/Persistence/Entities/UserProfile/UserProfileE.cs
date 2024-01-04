using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookshelf.Infra.Persistence.Entities.UserProfile;

[Table("UserProfile")]
public class UserProfileE
{
    [Key]
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;
}