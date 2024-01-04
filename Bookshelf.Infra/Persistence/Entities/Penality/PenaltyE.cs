using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bookshelf.Infra.Persistence.Entities.Base;
using Bookshelf.Infra.Persistence.Entities.Borrowing;
using Bookshelf.Infra.Persistence.Entities.PenalityType;

namespace Bookshelf.Infra.Persistence.Entities.Penality;

[Table("Penality")]
public class PenalityE: BaseEntity
{
    [Key] public long Id { get; set; }
    
    [ForeignKey("Borrowing")] 
    [Required]
    public long BorrowingId { get; set; }
    public BorrowingE Borrowing { get; set; }
    
    [ForeignKey("PenalityType")] 
    [Required]
    public long PenalityTypeId { get; set; }
    public PenalityTypeE PenalityType { get; set; }
}