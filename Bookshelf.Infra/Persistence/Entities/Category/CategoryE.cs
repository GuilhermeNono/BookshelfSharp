using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookshelf.Infra.Persistence.Entities.Category;

[Table("Category")]
public class CategoryE
{
    [Key]
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;
}