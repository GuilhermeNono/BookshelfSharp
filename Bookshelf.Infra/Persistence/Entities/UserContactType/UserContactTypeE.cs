using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookshelf.Infra.Persistence.Entities.UserContactType;

[Table("UserContactType")]
public class UserContactTypeE
{
    [Key]
    public long Id { get; set; }

    public string Description { get; set; } = string.Empty;
}