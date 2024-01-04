using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookshelf.Infra.Persistence.Entities.PenalityType;

[Table("PenalityType")]
public class PenalityTypeE
{
    [Key] public long Id { get; set; }
    public string Description { get; set; } = string.Empty;
}