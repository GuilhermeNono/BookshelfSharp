using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookshelf.Infra.Persistence.Entities.Publisher;

[Table("Publisher")]
public class PublisherE
{
    [Key]
    public long Id { get; set; }

    [Required] 
    public string Name { get; set; } = string.Empty;
}