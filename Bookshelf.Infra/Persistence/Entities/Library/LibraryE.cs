using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.Institution;

namespace Bookshelf.Infra.Persistence.Entities.Library;

[Table("Library")]
public class LibraryE
{
    [Key]
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public bool Active { get; set; }
    
    [ForeignKey("Institution")] 
    public long InstitutionId { get; set; }
    public InstitutionE Institution { get; set; }
}